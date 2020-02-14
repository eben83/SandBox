using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OdeToFood.Data;

namespace OdeToFood.Pages.R2
{
    public class CreateModel : PageModel
    {
        private readonly OdeToFood.Data.OdeToFoodDbContext _context;

        public CreateModel(OdeToFood.Data.OdeToFoodDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Restarant Restarant { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Restarants.Add(Restarant);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
