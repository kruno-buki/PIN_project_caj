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
    public class SpecialEditionsController : Controller
    {
        private readonly čajeviContext _context;

        public SpecialEditionsController(čajeviContext context)
        {
            _context = context;
        }

        // GET: SpecialEditions
        [Authorize]
        public async Task<IActionResult> Index(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            var prem = from cl in _context.SpecialEdition
                       select cl;
            if (!String.IsNullOrEmpty(searchString))
            {
                prem = prem.Where(cl => cl.ime.Contains(searchString));
            }
            return View(await prem.AsNoTracking().ToListAsync());
        }
    

    // GET: SpecialEditions/Details/5
    public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specialEdition = await _context.SpecialEdition
                .FirstOrDefaultAsync(m => m.ID == id);
            if (specialEdition == null)
            {
                return NotFound();
            }

            return View(specialEdition);
        }

        // GET: SpecialEditions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SpecialEditions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ime,podrijetlo,vrsta,godina,kilaza,komada")] SpecialEdition specialEdition)
        {
            if (ModelState.IsValid)
            {
                _context.Add(specialEdition);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(specialEdition);
        }

        // GET: SpecialEditions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specialEdition = await _context.SpecialEdition.FindAsync(id);
            if (specialEdition == null)
            {
                return NotFound();
            }
            return View(specialEdition);
        }

        // POST: SpecialEditions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ime,podrijetlo,vrsta,godina,kilaza,komada")] SpecialEdition specialEdition)
        {
            if (id != specialEdition.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(specialEdition);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpecialEditionExists(specialEdition.ID))
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
            return View(specialEdition);
        }

        // GET: SpecialEditions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specialEdition = await _context.SpecialEdition
                .FirstOrDefaultAsync(m => m.ID == id);
            if (specialEdition == null)
            {
                return NotFound();
            }

            return View(specialEdition);
        }

        // POST: SpecialEditions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var specialEdition = await _context.SpecialEdition.FindAsync(id);
            _context.SpecialEdition.Remove(specialEdition);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpecialEditionExists(int id)
        {
            return _context.SpecialEdition.Any(e => e.ID == id);
        }
    }
}
