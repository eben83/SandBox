using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OdeToFood.Data;

namespace OdeToFood.Pages.R2
{
    public class EditModel : PageModel
    {
        private readonly OdeToFood.Data.OdeToFoodDbContext _context;

        public EditModel(OdeToFood.Data.OdeToFoodDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Restarant Restarant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Restarant = await _context.Restarants.FirstOrDefaultAsync(m => m.ID == id);

            if (Restarant == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Restarant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RestarantExists(Restarant.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RestarantExists(int id)
        {
            return _context.Restarants.Any(e => e.ID == id);
        }
    }
}
