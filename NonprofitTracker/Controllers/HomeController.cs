using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NonprofitTracker.Data;
using NonprofitTracker.Models;
using NonprofitTracker.ViewModels;
using NonprofitTracker.Extensions;

namespace NonprofitTracker.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var dashboardData = new DashboardViewModel
        {
            TotalConstituents = await _context.Constituents.CountAsync(),
            TotalDonations = (double)(await _context.Donations.ToListAsync()).SafeSum(d => d.Amount),
            TotalCampaigns = await _context.Campaigns.CountAsync(c => c.IsActive),
            PendingServiceRequests = await _context.ServiceRequests.CountAsync(sr => sr.Status == RequestStatus.Pending),
            ActivePrograms = await _context.Programs.CountAsync(p => p.IsActive)
        };

        // Recent donations
        dashboardData.RecentDonations = await _context.Donations
            .Include(d => d.Constituent)
            .Include(d => d.Campaign)
            .OrderByDescending(d => d.DonationDate)
            .Take(10)
            .Select(d => new RecentDonation
            {
                ConstituentName = d.Constituent.FullName,
                Amount = d.Amount,
                Date = d.DonationDate,
                GiftType = d.GiftType.ToString(),
                CampaignName = d.Campaign != null ? d.Campaign.Name : null
            })
            .ToListAsync();

        // Monthly trends (last 12 months)
        var startDate = DateTime.Today.AddMonths(-11).Date;
        var monthlyData = await _context.Donations
            .Where(d => d.DonationDate >= startDate)
            .ToListAsync();
        
        dashboardData.MonthlyTrends = monthlyData
            .GroupBy(d => new { d.DonationDate.Year, d.DonationDate.Month })
            .Select(g => new MonthlyDonationTrend
            {
                Month = $"{g.Key.Year}-{g.Key.Month:00}",
                Amount = g.SafeSum(d => d.Amount),
                DonationCount = g.Count()
            })
            .OrderBy(t => t.Month)
            .ToList();

        // Campaign progress
        var activeCampaigns = await _context.Campaigns
            .Where(c => c.IsActive)
            .Include(c => c.Donations)
            .ToListAsync();
        
        dashboardData.CampaignProgress = activeCampaigns
            .Select(c => new CampaignProgress
            {
                CampaignName = c.Name,
                GoalAmount = c.GoalAmount,
                RaisedAmount = c.Donations.SafeSum(d => d.Amount),
                ProgressPercentage = c.GoalAmount > 0 ? (c.Donations.SafeSum(d => d.Amount) / c.GoalAmount) * 100 : 0,
                DaysRemaining = c.EndDate.HasValue ? (int)(c.EndDate.Value - DateTime.Today).TotalDays : 0
            })
            .ToList();

        // Service request summary
        dashboardData.ServiceRequestSummary = await _context.ServiceRequests
            .GroupBy(sr => sr.Status)
            .Select(g => new ServiceRequestSummary
            {
                Status = g.Key,
                Count = g.Count()
            })
            .ToListAsync();

        return View(dashboardData);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
