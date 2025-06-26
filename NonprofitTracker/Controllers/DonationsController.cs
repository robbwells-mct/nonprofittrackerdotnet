using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NonprofitTracker.Data;
using NonprofitTracker.Models;
using NonprofitTracker.Extensions;

namespace NonprofitTracker.Controllers
{
    public class DonationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DonationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Donations
        public async Task<IActionResult> Index(int page = 1, int pageSize = 20)
        {
            var donations = _context.Donations
                .Include(d => d.Campaign)
                .Include(d => d.Constituent)
                .OrderByDescending(d => d.DonationDate);

            var totalCount = await donations.CountAsync();
            var items = await donations
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            // Calculate totals safely for SQLite
            var allDonations = await _context.Donations.ToListAsync();
            var totalAmount = allDonations.SafeSum(d => d.Amount);
            var averageAmount = allDonations.SafeAverage(d => d.Amount);
            var thisMonthCount = allDonations.Where(d => d.DonationDate.Month == DateTime.Now.Month && d.DonationDate.Year == DateTime.Now.Year).Count();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            ViewBag.TotalCount = totalCount;
            ViewBag.TotalAmount = totalAmount;
            ViewBag.AverageAmount = averageAmount;
            ViewBag.ThisMonthCount = thisMonthCount;

            return View(items);
        }

        // GET: Donations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donation = await _context.Donations
                .Include(d => d.Campaign)
                .Include(d => d.Constituent)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (donation == null)
            {
                return NotFound();
            }

            return View(donation);
        }

        // GET: Donations/Create
        public IActionResult Create(int? constituentId)
        {
            ViewData["CampaignId"] = new SelectList(_context.Campaigns.Where(c => c.IsActive), "Id", "Name");
            
            if (constituentId.HasValue)
            {
                ViewData["ConstituentId"] = new SelectList(_context.Constituents.Where(c => c.Id == constituentId), "Id", "FullName", constituentId);
            }
            else
            {
                ViewData["ConstituentId"] = new SelectList(_context.Constituents.OrderBy(c => c.LastName), "Id", "FullName");
            }

            var donation = new Donation();
            if (constituentId.HasValue)
            {
                donation.ConstituentId = constituentId.Value;
            }

            return View(donation);
        }

        // POST: Donations/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ConstituentId,CampaignId,Amount,GiftType,DonationType,DonationDate,IsRecurring,RecurringFrequency,NextRecurringDate,AcknowledgmentStatus,CheckNumber,CreditCardLast4,Notes")] Donation donation)
        {
            if (ModelState.IsValid)
            {
                donation.DateCreated = DateTime.UtcNow;
                donation.CreatedDate = DateTime.UtcNow;
                donation.LastUpdated = DateTime.UtcNow;
                donation.UpdatedDate = DateTime.UtcNow;
                
                // Set acknowledgment sent based on status
                donation.AcknowledgmentSent = donation.AcknowledgmentStatus == AcknowledgmentStatus.Sent;
                if (donation.AcknowledgmentSent)
                {
                    donation.AcknowledgmentDate = DateTime.UtcNow;
                }
                
                // Set next recurring date if this is a recurring donation
                if (donation.IsRecurring && donation.RecurringFrequency.HasValue)
                {
                    donation.NextRecurringDate = donation.RecurringFrequency.Value switch
                    {
                        RecurringFrequency.Weekly => donation.DonationDate.AddDays(7),
                        RecurringFrequency.Monthly => donation.DonationDate.AddMonths(1),
                        RecurringFrequency.Quarterly => donation.DonationDate.AddMonths(3),
                        RecurringFrequency.SemiAnnual => donation.DonationDate.AddMonths(6),
                        RecurringFrequency.Annual => donation.DonationDate.AddYears(1),
                        _ => null
                    };
                }

                _context.Add(donation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["CampaignId"] = new SelectList(_context.Campaigns.Where(c => c.IsActive), "Id", "Name", donation.CampaignId);
            ViewData["ConstituentId"] = new SelectList(_context.Constituents.OrderBy(c => c.LastName), "Id", "FullName", donation.ConstituentId);
            return View(donation);
        }

        // GET: Donations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donation = await _context.Donations.FindAsync(id);
            if (donation == null)
            {
                return NotFound();
            }

            ViewData["CampaignId"] = new SelectList(_context.Campaigns.Where(c => c.IsActive), "Id", "Name", donation.CampaignId);
            ViewData["ConstituentId"] = new SelectList(_context.Constituents.OrderBy(c => c.LastName), "Id", "FullName", donation.ConstituentId);
            return View(donation);
        }

        // POST: Donations/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ConstituentId,CampaignId,Amount,GiftType,DonationType,DonationDate,IsRecurring,RecurringFrequency,NextRecurringDate,AcknowledgmentStatus,AcknowledgmentSent,AcknowledgmentDate,CheckNumber,CreditCardLast4,Notes,DateCreated,CreatedDate,UpdatedDate")] Donation donation)
        {
            if (id != donation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    donation.LastUpdated = DateTime.UtcNow;
                    _context.Update(donation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DonationExists(donation.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            ViewData["CampaignId"] = new SelectList(_context.Campaigns.Where(c => c.IsActive), "Id", "Name", donation.CampaignId);
            ViewData["ConstituentId"] = new SelectList(_context.Constituents.OrderBy(c => c.LastName), "Id", "FullName", donation.ConstituentId);
            return View(donation);
        }

        // POST: Mark Acknowledgment Sent
        [HttpPost]
        public async Task<IActionResult> MarkAcknowledgmentSent(int id)
        {
            var donation = await _context.Donations.FindAsync(id);
            if (donation != null)
            {
                donation.AcknowledgmentSent = true;
                donation.AcknowledgmentDate = DateTime.UtcNow;
                donation.LastUpdated = DateTime.UtcNow;
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Donations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donation = await _context.Donations
                .Include(d => d.Campaign)
                .Include(d => d.Constituent)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (donation == null)
            {
                return NotFound();
            }

            return View(donation);
        }

        // POST: Donations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var donation = await _context.Donations.FindAsync(id);
            if (donation != null)
            {
                _context.Donations.Remove(donation);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DonationExists(int id)
        {
            return _context.Donations.Any(e => e.Id == id);
        }
    }
}
