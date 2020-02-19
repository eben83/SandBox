using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restarants
{
    public class DeleteModel : PageModel
    {
        private readonly IRestaurantData restrantData;
        public Restarant Restarant { get; set; }

        public DeleteModel(IRestaurantData restrantData)
        {
            this.restrantData = restrantData;
        }

        public IActionResult OnGet(int restarantId)
        {
            Restarant = restrantData.GetById(restarantId);
            if(Restarant == null)
            {
                return RedirectToPage("./NotFound");

            }
            return Page();
            
        }

        public IActionResult OnPost(int restarantId)
        {
            var restarant = restrantData.Delete(restarantId);
            restrantData.Commit();

            if(restarant == null)
            {
                return RedirectToPage("./NotFound");
            }

            TempData["Message"] = $"{restarant.Name} deleted";
            return RedirectToPage("./List");
        }
    }
}
