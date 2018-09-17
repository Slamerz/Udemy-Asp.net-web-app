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
    public class LexiconController : Controller
    {
        private readonly LexiconContext _context;

        public LexiconController(LexiconContext context)
        {
            _context = context;
        }

        // GET: Lexicon
        public async Task<IActionResult> Index()
        {
            return View(await _context.Lexicons.ToListAsync());
        }

        // GET: Lexicon/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lexicon = await _context.Lexicons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lexicon == null)
            {
                return NotFound();
            }

            return View(lexicon);
        }

        // GET: Lexicon/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lexicon/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Adjective,Definition,See1,See2,See3")] Lexicon lexicon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lexicon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lexicon);
        }

        // GET: Lexicon/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lexicon = await _context.Lexicons.FindAsync(id);
            if (lexicon == null)
            {
                return NotFound();
            }
            return View(lexicon);
        }

        // POST: Lexicon/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name,Adjective,Definition,See1,See2,See3")] Lexicon lexicon)
        {
            if (id != lexicon.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lexicon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LexiconExists(lexicon.Id))
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
            return View(lexicon);
        }

        // GET: Lexicon/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lexicon = await _context.Lexicons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lexicon == null)
            {
                return NotFound();
            }

            return View(lexicon);
        }

        // POST: Lexicon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var lexicon = await _context.Lexicons.FindAsync(id);
            _context.Lexicons.Remove(lexicon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LexiconExists(long id)
        {
            return _context.Lexicons.Any(e => e.Id == id);
        }
    }
}
