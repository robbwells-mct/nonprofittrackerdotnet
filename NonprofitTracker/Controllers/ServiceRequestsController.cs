using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NonprofitTracker.Data;
using NonprofitTracker.Models;

namespace NonprofitTracker.Controllers
{
    public class ServiceRequestsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ServiceRequestsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ServiceRequests
        public async Task<IActionResult> Index(RequestStatus? status, Priority? priority, int page = 1, int pageSize = 20)
        {
            var query = _context.ServiceRequests
                .Include(s => s.Constituent)
                .AsQueryable();

            if (status.HasValue)
            {
                query = query.Where(s => s.Status == status.Value);
            }

            if (priority.HasValue)
            {
                query = query.Where(s => s.Priority == priority.Value);
            }

            // Order by priority (Urgent first) then by date requested
            query = query.OrderBy(s => s.Status == RequestStatus.Completed ? 1 : 0)
                         .ThenByDescending(s => (int)s.Priority)
                         .ThenBy(s => s.DateRequested);

            var totalCount = await query.CountAsync();
            var items = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            ViewBag.CurrentStatus = status;
            ViewBag.CurrentPriority = priority;

            return View(items);
        }

        // GET: ServiceRequests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceRequest = await _context.ServiceRequests
                .Include(s => s.Constituent)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (serviceRequest == null)
            {
                return NotFound();
            }

            return View(serviceRequest);
        }

        // GET: ServiceRequests/Create
        public IActionResult Create(int? constituentId)
        {
            if (constituentId.HasValue)
            {
                ViewData["ConstituentId"] = new SelectList(_context.Constituents.Where(c => c.Id == constituentId), "Id", "FullName", constituentId);
            }
            else
            {
                ViewData["ConstituentId"] = new SelectList(_context.Constituents.OrderBy(c => c.LastName), "Id", "FullName");
            }

            var serviceRequest = new ServiceRequest();
            if (constituentId.HasValue)
            {
                serviceRequest.ConstituentId = constituentId.Value;
            }

            return View(serviceRequest);
        }

        // POST: ServiceRequests/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ConstituentId,Title,Description,RequestType,Priority,AssignedStaff,Department,DueDate")] ServiceRequest serviceRequest)
        {
            if (ModelState.IsValid)
            {
                serviceRequest.DateRequested = DateTime.UtcNow;
                serviceRequest.DateCreated = DateTime.UtcNow;
                serviceRequest.LastUpdated = DateTime.UtcNow;
                serviceRequest.Status = RequestStatus.Pending;

                if (!string.IsNullOrEmpty(serviceRequest.AssignedStaff))
                {
                    serviceRequest.Status = RequestStatus.InProgress;
                    serviceRequest.DateAssigned = DateTime.UtcNow;
                }

                _context.Add(serviceRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["ConstituentId"] = new SelectList(_context.Constituents.OrderBy(c => c.LastName), "Id", "FullName", serviceRequest.ConstituentId);
            return View(serviceRequest);
        }

        // GET: ServiceRequests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceRequest = await _context.ServiceRequests.FindAsync(id);
            if (serviceRequest == null)
            {
                return NotFound();
            }

            ViewData["ConstituentId"] = new SelectList(_context.Constituents.OrderBy(c => c.LastName), "Id", "FullName", serviceRequest.ConstituentId);
            return View(serviceRequest);
        }

        // POST: ServiceRequests/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ConstituentId,Title,Description,RequestType,Priority,Status,AssignedStaff,Department,DateRequested,DateAssigned,DateCompleted,DueDate,ResolutionNotes,DateCreated")] ServiceRequest serviceRequest)
        {
            if (id != serviceRequest.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    serviceRequest.LastUpdated = DateTime.UtcNow;

                    // Update status-related dates
                    var existingRequest = await _context.ServiceRequests.AsNoTracking().FirstOrDefaultAsync(s => s.Id == id);
                    
                    if (existingRequest != null)
                    {
                        // If status changed to In Progress and wasn't before, set DateAssigned
                        if (serviceRequest.Status == RequestStatus.InProgress && existingRequest.Status != RequestStatus.InProgress)
                        {
                            serviceRequest.DateAssigned = DateTime.UtcNow;
                        }

                        // If status changed to Completed and wasn't before, set DateCompleted
                        if (serviceRequest.Status == RequestStatus.Completed && existingRequest.Status != RequestStatus.Completed)
                        {
                            serviceRequest.DateCompleted = DateTime.UtcNow;
                        }
                    }

                    _context.Update(serviceRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceRequestExists(serviceRequest.Id))
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

            ViewData["ConstituentId"] = new SelectList(_context.Constituents.OrderBy(c => c.LastName), "Id", "FullName", serviceRequest.ConstituentId);
            return View(serviceRequest);
        }

        // GET: ServiceRequests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceRequest = await _context.ServiceRequests
                .Include(s => s.Constituent)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (serviceRequest == null)
            {
                return NotFound();
            }

            return View(serviceRequest);
        }

        // POST: ServiceRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var serviceRequest = await _context.ServiceRequests.FindAsync(id);
            if (serviceRequest != null)
            {
                _context.ServiceRequests.Remove(serviceRequest);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceRequestExists(int id)
        {
            return _context.ServiceRequests.Any(e => e.Id == id);
        }
    }
}
