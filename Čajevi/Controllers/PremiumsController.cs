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
    public class PremiumsController : Controller
    {
        private readonly čajeviContext _context;

        public PremiumsController(čajeviContext context)
        {
            _context = context;
        }

        // GET: Premiums
        [Authorize]
        public async Task<IActionResult> Index(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            var prem = from cl in _context.Premium
                       select cl;
            if (!String.IsNullOrEmpty(searchString))
            {
                prem = prem.Where(cl => cl.ime.Contains(searchString));
            }
            return View(await prem.AsNoTracking().ToListAsync());
        }

        // GET: Premiums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var premium = await _context.Premium
                .FirstOrDefaultAsync(m => m.ID == id);
            if (premium == null)
            {
                return NotFound();
            }

            return View(premium);
        }

        // GET: Premiums/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Premiums/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ime,podrijetlo,vrsta,godina,kilaza,komada")] Premium premium)
        {
            if (ModelState.IsValid)
            {
                _context.Add(premium);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(premium);
        }

        // GET: Premiums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var premium = await _context.Premium.FindAsync(id);
            if (premium == null)
            {
                return NotFound();
            }
            return View(premium);
        }

        // POST: Premiums/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ime,podrijetlo,vrsta,godina,kilaza,komada")] Premium premium)
        {
            if (id != premium.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(premium);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PremiumExists(premium.ID))
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
            return View(premium);
        }

        // GET: Premiums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var premium = await _context.Premium
                .FirstOrDefaultAsync(m => m.ID == id);
            if (premium == null)
            {
                return NotFound();
            }

            return View(premium);
        }

        // POST: Premiums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var premium = await _context.Premium.FindAsync(id);
            _context.Premium.Remove(premium);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PremiumExists(int id)
        {
            return _context.Premium.Any(e => e.ID == id);
        }
    }
}
