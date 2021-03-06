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
    public class IndexModel : PageModel
    {
        private readonly OdeToFood.Data.OdeToFoodDbContext _context;

        public IndexModel(OdeToFood.Data.OdeToFoodDbContext context)
        {
            _context = context;
        }

        public IList<Restarant> Restarant { get;set; }

        public async Task OnGetAsync()
        {
            Restarant = await _context.Restarants.ToListAsync();
        }
    }
}
