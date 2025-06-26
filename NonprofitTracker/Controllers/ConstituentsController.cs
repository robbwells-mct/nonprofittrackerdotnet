using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NonprofitTracker.Data;
using NonprofitTracker.Models;
using NonprofitTracker.ViewModels;

namespace NonprofitTracker.Controllers
{
    public class ConstituentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ConstituentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Constituents
        public async Task<IActionResult> Index(ConstituentSearchViewModel model)
        {
            var query = _context.Constituents.AsQueryable();

            // Apply filters
            if (!string.IsNullOrEmpty(model.SearchTerm))
            {
                query = query.Where(c => c.FirstName.Contains(model.SearchTerm) ||
                                        c.LastName.Contains(model.SearchTerm) ||
                                        c.Email!.Contains(model.SearchTerm));
            }

            if (!string.IsNullOrEmpty(model.City))
            {
                query = query.Where(c => c.City == model.City);
            }

            if (!string.IsNullOrEmpty(model.State))
            {
                query = query.Where(c => c.State == model.State);
            }

            if (model.IsVolunteer.HasValue)
            {
                query = query.Where(c => c.IsVolunteer == model.IsVolunteer.Value);
            }

            if (model.PreferredCommunication.HasValue)
            {
                query = query.Where(c => c.PreferredCommunication == model.PreferredCommunication.Value);
            }

            // Apply sorting
            query = model.SortBy.ToLower() switch
            {
                "firstname" => model.SortDirection == "desc" ? query.OrderByDescending(c => c.FirstName) : query.OrderBy(c => c.FirstName),
                "lastname" => model.SortDirection == "desc" ? query.OrderByDescending(c => c.LastName) : query.OrderBy(c => c.LastName),
                "email" => model.SortDirection == "desc" ? query.OrderByDescending(c => c.Email) : query.OrderBy(c => c.Email),
                "city" => model.SortDirection == "desc" ? query.OrderByDescending(c => c.City) : query.OrderBy(c => c.City),
                "datecreated" => model.SortDirection == "desc" ? query.OrderByDescending(c => c.DateCreated) : query.OrderBy(c => c.DateCreated),
                _ => query.OrderBy(c => c.LastName)
            };

            model.TotalCount = await query.CountAsync();
            model.Results = await query
                .Skip((model.Page - 1) * model.PageSize)
                .Take(model.PageSize)
                .ToListAsync();

            return View(model);
        }

        // GET: Constituents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var constituent = await _context.Constituents
                .Include(c => c.Donations)
                    .ThenInclude(d => d.Campaign)
                .Include(c => c.ConstituentPrograms)
                    .ThenInclude(cp => cp.Program)
                .Include(c => c.ServiceRequests)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (constituent == null)
            {
                return NotFound();
            }

            return View(constituent);
        }

        // GET: Constituents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Constituents/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,Email,PhoneNumber,AddressLine1,AddressLine2,City,State,ZipCode,Country,DateOfBirth,Gender,IsVolunteer,PreferredCommunication,Notes")] Constituent constituent)
        {
            if (ModelState.IsValid)
            {
                constituent.DateCreated = DateTime.UtcNow;
                constituent.LastUpdated = DateTime.UtcNow;
                _context.Add(constituent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(constituent);
        }

        // GET: Constituents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var constituent = await _context.Constituents.FindAsync(id);
            if (constituent == null)
            {
                return NotFound();
            }
            return View(constituent);
        }

        // POST: Constituents/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Email,PhoneNumber,AddressLine1,AddressLine2,City,State,ZipCode,Country,DateOfBirth,Gender,IsVolunteer,PreferredCommunication,Notes,DateCreated")] Constituent constituent)
        {
            if (id != constituent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    constituent.LastUpdated = DateTime.UtcNow;
                    _context.Update(constituent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConstituentExists(constituent.Id))
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
            return View(constituent);
        }

        // GET: Constituents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var constituent = await _context.Constituents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (constituent == null)
            {
                return NotFound();
            }

            return View(constituent);
        }

        // POST: Constituents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var constituent = await _context.Constituents.FindAsync(id);
            if (constituent != null)
            {
                _context.Constituents.Remove(constituent);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConstituentExists(int id)
        {
            return _context.Constituents.Any(e => e.Id == id);
        }
    }
}
