using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restarants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRestaurantData restaurantData; // initialized- "Alt + ."

        public string Message { get; set; }
        public IEnumerable<Restarant> Restarants { get; set; }

        public ListModel(IConfiguration config,
                         IRestaurantData restaurantData)
            /* above are the servises available for this page*/
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }

        public void OnGet(string searchTerm)
        {
            

            Message = config["Message"]; /* this line accesses the AppSetting file*/
            Restarants = restaurantData.GetRestaurantsByName(searchTerm);
        }
    }
}
