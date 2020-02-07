using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restarants
{
    public class DetailModel : PageModel
    {
        public Restarant Restarant { get; set; }

        public void OnGet(int restarantID)
        {
            Restarant = new Restarant();
            Restarant.ID = restarantID; // populat the restarant ID
        }
    }
}
