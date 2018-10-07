using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TestAPI1.Models;

namespace TestAPI1.Controllers
{
    public class ClansController : Controller
    {
        private readonly LexiconContext _context;

        public ClansController(LexiconContext context)
        {
            _context = context;
        }

        // GET: Clans
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clans.ToListAsync());
        }

        // GET: Clans/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clans = await _context.Clans
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clans == null)
            {
                return NotFound();
            }

            return View(clans);
        }

        // GET: Clans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Bane")] Clans clans)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clans);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clans);
        }

        // GET: Clans/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clans = await _context.Clans.FindAsync(id);
            if (clans == null)
            {
                return NotFound();
            }
            return View(clans);
        }

        // POST: Clans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name,Description,Bane")] Clans clans)
        {
            if (id != clans.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clans);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClansExists(clans.Id))
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
            return View(clans);
        }

        // GET: Clans/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clans = await _context.Clans
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clans == null)
            {
                return NotFound();
            }

            return View(clans);
        }

        // POST: Clans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var clans = await _context.Clans.FindAsync(id);
            _context.Clans.Remove(clans);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClansExists(long id)
        {
            return _context.Clans.Any(e => e.Id == id);
        }
    }
}
