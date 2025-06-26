using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NonprofitTracker.Data;
using NonprofitTracker.Models;
using NonprofitTracker.ViewModels;
using NonprofitTracker.Extensions;

namespace NonprofitTracker.Controllers
{
    public class ReportsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReportsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Reports
        public IActionResult Index()
        {
            return View();
        }

        // GET: Reports/Donations
        public async Task<IActionResult> Donations(DonationReportViewModel model)
        {
            model.AvailableCampaigns = await _context.Campaigns.OrderBy(c => c.Name).ToListAsync();

            var query = _context.Donations
                .Include(d => d.Constituent)
                .Include(d => d.Campaign)
                .AsQueryable();

            // Apply filters
            if (model.StartDate.HasValue)
            {
                query = query.Where(d => d.DonationDate >= model.StartDate.Value);
            }

            if (model.EndDate.HasValue)
            {
                query = query.Where(d => d.DonationDate <= model.EndDate.Value);
            }

            if (model.CampaignId.HasValue)
            {
                query = query.Where(d => d.CampaignId == model.CampaignId.Value);
            }

            if (model.GiftType.HasValue)
            {
                query = query.Where(d => d.GiftType == model.GiftType.Value);
            }

            model.Donations = await query
                .OrderByDescending(d => d.DonationDate)
                .Select(d => new DonationReportItem
                {
                    Date = d.DonationDate,
                    ConstituentName = d.Constituent.FullName,
                    Amount = d.Amount,
                    GiftType = d.GiftType.ToString(),
                    CampaignName = d.Campaign != null ? d.Campaign.Name : null,
                    AcknowledgmentSent = d.AcknowledgmentSent
                })
                .ToListAsync();

            model.TotalAmount = model.Donations.SafeSum(d => d.Amount);
            model.TotalCount = model.Donations.Count;

            return View(model);
        }

        // GET: Reports/ConstituentAnalytics
        public async Task<IActionResult> ConstituentAnalytics()
        {
            var analytics = new
            {
                TotalConstituents = await _context.Constituents.CountAsync(),
                VolunteerCount = await _context.Constituents.CountAsync(c => c.IsVolunteer),
                DonorCount = await _context.Constituents.CountAsync(c => c.Donations.Any()),
                
                // Demographics
                GenderBreakdown = await _context.Constituents
                    .Where(c => !string.IsNullOrEmpty(c.Gender))
                    .GroupBy(c => c.Gender)
                    .Select(g => new { Gender = g.Key, Count = g.Count() })
                    .ToListAsync(),

                StateBreakdown = await _context.Constituents
                    .Where(c => !string.IsNullOrEmpty(c.State))
                    .GroupBy(c => c.State)
                    .Select(g => new { State = g.Key, Count = g.Count() })
                    .OrderByDescending(x => x.Count)
                    .Take(10)
                    .ToListAsync(),

                CommunicationPreferences = await _context.Constituents
                    .GroupBy(c => c.PreferredCommunication)
                    .Select(g => new { Preference = g.Key.ToString(), Count = g.Count() })
                    .ToListAsync(),

                // Donation statistics
                TopDonors = (await _context.Constituents
                    .Where(c => c.Donations.Any())
                    .Include(c => c.Donations)
                    .ToListAsync())
                    .Select(c => new
                    {
                        Name = c.FullName,
                        TotalDonated = c.Donations.SafeSum(d => d.Amount),
                        DonationCount = c.Donations.Count()
                    })
                    .OrderByDescending(x => x.TotalDonated)
                    .Take(10)
                    .ToList(),

                MonthlyGrowth = (await _context.Constituents
                    .Where(c => c.DateCreated >= DateTime.Today.AddMonths(-12))
                    .GroupBy(c => new { c.DateCreated.Year, c.DateCreated.Month })
                    .Select(g => new
                    {
                        Year = g.Key.Year,
                        Month = g.Key.Month,
                        NewConstituents = g.Count()
                    })
                    .ToListAsync())
                    .Select(x => new
                    {
                        Month = $"{x.Year}-{x.Month:00}",
                        NewConstituents = x.NewConstituents
                    })
                    .OrderBy(x => x.Month)
                    .ToList()
            };

            return View(analytics);
        }

        // GET: Reports/CampaignPerformance
        public async Task<IActionResult> CampaignPerformance()
        {
            var campaignsData = await _context.Campaigns
                .Include(c => c.Donations)
                    .ThenInclude(d => d.Constituent)
                .ToListAsync();
            
            var campaigns = campaignsData
                .Select(c => new
                {
                    Campaign = c,
                    TotalRaised = c.Donations.SafeSum(d => d.Amount),
                    DonorCount = c.Donations.Select(d => d.ConstituentId).Distinct().Count(),
                    AverageDonation = c.Donations.Any() ? c.Donations.SafeAverage(d => d.Amount) : 0,
                    LargestDonation = c.Donations.Any() ? c.Donations.Max(d => d.Amount) : 0,
                    DonationsByMonth = c.Donations
                        .GroupBy(d => new { d.DonationDate.Year, d.DonationDate.Month })
                        .Select(g => new
                        {
                            Month = $"{g.Key.Year}-{g.Key.Month:00}",
                            Amount = g.SafeSum(d => d.Amount),
                            Count = g.Count()
                        })
                        .OrderBy(x => x.Month)
                        .ToList()
                })
                .OrderByDescending(x => x.TotalRaised)
                .ToList();

            return View(campaigns);
        }

        // GET: Reports/ServiceRequests
        public async Task<IActionResult> ServiceRequests()
        {
            var analytics = new
            {
                TotalRequests = await _context.ServiceRequests.CountAsync(),
                PendingRequests = await _context.ServiceRequests.CountAsync(sr => sr.Status == RequestStatus.Pending),
                InProgressRequests = await _context.ServiceRequests.CountAsync(sr => sr.Status == RequestStatus.InProgress),
                CompletedRequests = await _context.ServiceRequests.CountAsync(sr => sr.Status == RequestStatus.Completed),
                OverdueRequests = await _context.ServiceRequests.CountAsync(sr => sr.DueDate < DateTime.Today && sr.Status != RequestStatus.Completed),

                RequestsByType = await _context.ServiceRequests
                    .GroupBy(sr => sr.RequestType)
                    .Select(g => new { Type = g.Key.ToString(), Count = g.Count() })
                    .OrderByDescending(x => x.Count)
                    .ToListAsync(),

                RequestsByPriority = await _context.ServiceRequests
                    .GroupBy(sr => sr.Priority)
                    .Select(g => new { Priority = g.Key.ToString(), Count = g.Count() })
                    .ToListAsync(),

                RequestsByStatus = await _context.ServiceRequests
                    .GroupBy(sr => sr.Status)
                    .Select(g => new { Status = g.Key.ToString(), Count = g.Count() })
                    .ToListAsync(),

                RequestsByDepartment = await _context.ServiceRequests
                    .Where(sr => !string.IsNullOrEmpty(sr.Department))
                    .GroupBy(sr => sr.Department)
                    .Select(g => new { Department = g.Key, Count = g.Count() })
                    .OrderByDescending(x => x.Count)
                    .ToListAsync(),

                MonthlyRequestTrends = (await _context.ServiceRequests
                    .Where(sr => sr.DateRequested >= DateTime.Today.AddMonths(-12))
                    .ToListAsync())
                    .GroupBy(sr => new { sr.DateRequested.Year, sr.DateRequested.Month })
                    .Select(g => new
                    {
                        Month = $"{g.Key.Year}-{g.Key.Month:00}",
                        RequestCount = g.Count(),
                        CompletedCount = g.Count(sr => sr.Status == RequestStatus.Completed),
                        AverageResolutionDays = g.Where(sr => sr.DateCompleted.HasValue).Any() 
                            ? g.Where(sr => sr.DateCompleted.HasValue).Average(sr => (sr.DateCompleted!.Value - sr.DateRequested).TotalDays)
                            : 0
                    })
                    .OrderBy(x => x.Month)
                    .ToList()
            };

            return View(analytics);
        }
    }
}
