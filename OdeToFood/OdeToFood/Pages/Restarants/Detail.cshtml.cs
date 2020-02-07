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
        private readonly IRestaurantData restaurantData;

        public Restarant Restarant { get; set; }

        public DetailModel(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }

        public IActionResult OnGet(int restarantId)
        {
            Restarant = restaurantData.GetById(restarantId);

            //error handel
            if(Restarant == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
            
        }
    }
}
