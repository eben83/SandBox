using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OdeToFood.Data;
using OdeToFood.Core;


namespace OdeToFood.Pages.R2
{
    public class DeleteModel : PageModel
    {
        private readonly OdeToFood.Data.OdeToFoodDbContext _context;

        public DeleteModel(OdeToFood.Data.OdeToFoodDbContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Restarant = await _context.Restarants.FindAsync(id);

            if (Restarant != null)
            {
                _context.Restarants.Remove(Restarant);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
