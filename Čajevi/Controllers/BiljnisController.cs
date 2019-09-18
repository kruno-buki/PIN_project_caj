using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Čajevi.Models;
using Microsoft.AspNetCore.Authorization;

namespace Čajevi.Controllers
{
    public class BiljnisController : Controller
    {
        private readonly čajeviContext _context;

        public BiljnisController(čajeviContext context)
        {
            _context = context;
        }

        // GET: Biljnis
        [Authorize]
        public async Task<IActionResult> Index(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            var prem = from cl in _context.Biljni
                       select cl;
            if (!String.IsNullOrEmpty(searchString))
            {
                prem = prem.Where(cl => cl.ime.Contains(searchString));
            }
            return View(await prem.AsNoTracking().ToListAsync());

        }
        
        // GET: Biljnis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var biljni = await _context.Biljni
                .FirstOrDefaultAsync(m => m.ID == id);
            if (biljni == null)
            {
                return NotFound();
            }

            return View(biljni);
        }

        // GET: Biljnis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Biljnis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ime,podrijetlo,vrsta,godina,kilaza,komada")] Biljni biljni)
        {
            if (ModelState.IsValid)
            {
                _context.Add(biljni);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(biljni);
        }

        // GET: Biljnis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var biljni = await _context.Biljni.FindAsync(id);
            if (biljni == null)
            {
                return NotFound();
            }
            return View(biljni);
        }

        // POST: Biljnis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ime,podrijetlo,vrsta,godina,kilaza,komada")] Biljni biljni)
        {
            if (id != biljni.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(biljni);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BiljniExists(biljni.ID))
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
            return View(biljni);
        }

        // GET: Biljnis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var biljni = await _context.Biljni
                .FirstOrDefaultAsync(m => m.ID == id);
            if (biljni == null)
            {
                return NotFound();
            }

            return View(biljni);
        }

        // POST: Biljnis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var biljni = await _context.Biljni.FindAsync(id);
            _context.Biljni.Remove(biljni);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BiljniExists(int id)
        {
            return _context.Biljni.Any(e => e.ID == id);
        }
    }
}
