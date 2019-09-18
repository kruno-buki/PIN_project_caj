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
    public class VoćniController : Controller
    {
        private readonly čajeviContext _context;

        public VoćniController(čajeviContext context)
        {
            _context = context;
        }

        // GET: Voćni
        [Authorize]
        public async Task<IActionResult> Index(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            var prem = from cl in _context.Voćni
                       select cl;
            if (!String.IsNullOrEmpty(searchString))
            {
                prem = prem.Where(cl => cl.ime.Contains(searchString));
            }
            return View(await prem.AsNoTracking().ToListAsync());
        }

        // GET: Voćni/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voćni = await _context.Voćni
                .FirstOrDefaultAsync(m => m.ID == id);
            if (voćni == null)
            {
                return NotFound();
            }

            return View(voćni);
        }

        // GET: Voćni/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Voćni/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ime,podrijetlo,vrsta,godina,kilaza,komada")] Voćni voćni)
        {
            if (ModelState.IsValid)
            {
                _context.Add(voćni);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(voćni);
        }

        // GET: Voćni/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voćni = await _context.Voćni.FindAsync(id);
            if (voćni == null)
            {
                return NotFound();
            }
            return View(voćni);
        }

        // POST: Voćni/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ime,podrijetlo,vrsta,godina,kilaza,komada")] Voćni voćni)
        {
            if (id != voćni.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(voćni);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VoćniExists(voćni.ID))
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
            return View(voćni);
        }

        // GET: Voćni/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voćni = await _context.Voćni
                .FirstOrDefaultAsync(m => m.ID == id);
            if (voćni == null)
            {
                return NotFound();
            }

            return View(voćni);
        }

        // POST: Voćni/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var voćni = await _context.Voćni.FindAsync(id);
            _context.Voćni.Remove(voćni);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VoćniExists(int id)
        {
            return _context.Voćni.Any(e => e.ID == id);
        }
    }
}
