#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SportsApp.Data;
using SportsApp.Models;

namespace SportsApp.Controllers
{
    public class TechnicianManagersController : Controller
    {
        private readonly SportsAppContext _context;

        public TechnicianManagersController(SportsAppContext context)
        {
            _context = context;
        }

        // GET: TechnicianManagers
        public async Task<IActionResult> Index()
        {
            return View(await _context.TechnicianManager.ToListAsync());
        }

        // GET: TechnicianManagers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var technicianManager = await _context.TechnicianManager
                .FirstOrDefaultAsync(m => m.Id == id);
            if (technicianManager == null)
            {
                return NotFound();
            }

            return View(technicianManager);
        }

        // GET: TechnicianManagers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TechnicianManagers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TechnicianName,TechnicianEmail,TechnicianPhone")] TechnicianManager technicianManager)
        {
            if (ModelState.IsValid)
            {
                _context.Add(technicianManager);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(technicianManager);
        }

        // GET: TechnicianManagers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var technicianManager = await _context.TechnicianManager.FindAsync(id);
            if (technicianManager == null)
            {
                return NotFound();
            }
            return View(technicianManager);
        }

        // POST: TechnicianManagers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TechnicianName,TechnicianEmail,TechnicianPhone")] TechnicianManager technicianManager)
        {
            if (id != technicianManager.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(technicianManager);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TechnicianManagerExists(technicianManager.Id))
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
            return View(technicianManager);
        }

        // GET: TechnicianManagers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var technicianManager = await _context.TechnicianManager
                .FirstOrDefaultAsync(m => m.Id == id);
            if (technicianManager == null)
            {
                return NotFound();
            }

            return View(technicianManager);
        }

        // POST: TechnicianManagers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var technicianManager = await _context.TechnicianManager.FindAsync(id);
            _context.TechnicianManager.Remove(technicianManager);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TechnicianManagerExists(int id)
        {
            return _context.TechnicianManager.Any(e => e.Id == id);
        }
    }
}
