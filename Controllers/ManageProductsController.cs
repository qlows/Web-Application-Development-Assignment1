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
    public class ManageProductsController : Controller
    {
        private readonly SportsAppContext _context;

        public ManageProductsController(SportsAppContext context)
        {
            _context = context;
        }

        // GET: ManageProducts
        public async Task<IActionResult> Index()
        {
            return View(await _context.ManageProducts.ToListAsync());
        }

        // GET: ManageProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manageProducts = await _context.ManageProducts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (manageProducts == null)
            {
                return NotFound();
            }

            return View(manageProducts);
        }

        // GET: ManageProducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ManageProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Code,Name,Price,ReleaseDate")] ManageProducts manageProducts)
        {
            if (ModelState.IsValid)
            {
                _context.Add(manageProducts);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(manageProducts);
        }

        // GET: ManageProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manageProducts = await _context.ManageProducts.FindAsync(id);
            if (manageProducts == null)
            {
                return NotFound();
            }
            return View(manageProducts);
        }

        // POST: ManageProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Code,Name,Price,ReleaseDate")] ManageProducts manageProducts)
        {
            if (id != manageProducts.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(manageProducts);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ManageProductsExists(manageProducts.Id))
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
            return View(manageProducts);
        }

        // GET: ManageProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manageProducts = await _context.ManageProducts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (manageProducts == null)
            {
                return NotFound();
            }

            return View(manageProducts);
        }

        // POST: ManageProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var manageProducts = await _context.ManageProducts.FindAsync(id);
            _context.ManageProducts.Remove(manageProducts);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ManageProductsExists(int id)
        {
            return _context.ManageProducts.Any(e => e.Id == id);
        }
    }
}
