using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Api
{
    public class RestarantsController : Controller
    {
        private readonly OdeToFoodDbContext _context;

        public RestarantsController(OdeToFoodDbContext context)
        {
            _context = context;
        }

        //GET: api/Restarants
        [HttpGet]
        public IEnumerable<Restarant> GetRestarants()
        {
            return _context.Restarants;
        }

        // GET: Restarants
        public async Task<IActionResult> Index()
        {
            return View(await _context.Restarants.ToListAsync());
        }

        // GET: Restarants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restarant = await _context.Restarants
                .FirstOrDefaultAsync(m => m.ID == id);
            if (restarant == null)
            {
                return NotFound();
            }

            return View(restarant);
        }

        // GET: Restarants/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Restarants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Location,Cuisine")] Restarant restarant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(restarant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(restarant);
        }

        // GET: Restarants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restarant = await _context.Restarants.FindAsync(id);
            if (restarant == null)
            {
                return NotFound();
            }
            return View(restarant);
        }

        // POST: Restarants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Location,Cuisine")] Restarant restarant)
        {
            if (id != restarant.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(restarant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RestarantExists(restarant.ID))
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
            return View(restarant);
        }

        // GET: Restarants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restarant = await _context.Restarants
                .FirstOrDefaultAsync(m => m.ID == id);
            if (restarant == null)
            {
                return NotFound();
            }

            return View(restarant);
        }

        // POST: Restarants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var restarant = await _context.Restarants.FindAsync(id);
            _context.Restarants.Remove(restarant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RestarantExists(int id)
        {
            return _context.Restarants.Any(e => e.ID == id);
        }
    }
}
