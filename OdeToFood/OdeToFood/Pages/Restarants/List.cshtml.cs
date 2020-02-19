using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Data;
using OdeToFood.Core;


namespace OdeToFood.Pages.Restarants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRestaurantData restaurantData; // initialized - "Alt + ."
       

        public string Message { get; set; } // initializes the property.
        public IEnumerable<Restarant> Restarants { get; set; }

        [BindProperty(SupportsGet = true)] /*since the SearchTerm property will have input the BindProperty will set up an HTTP request
        */
        public string SearchTerm { get; set; } /*Initializes the SearchTerm property*/
        /*having a property on this page- allows for it to be input and output
         this also makes an instance of the model */

        public ListModel(IConfiguration config,
                         IRestaurantData restaurantData)
            /* above are the servises available for this page*/
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }

        public void OnGet()
        {

            /*on this meathod- if the user doesn't search the method will pass the searchTerm will be Null and pass over it*/

            Message = config["Message"]; /* this line accesses the AppSetting file*/
            Restarants = restaurantData.GetRestaurantsByName(SearchTerm);
            /*pass the same searchTerm through the GetRestaurantsByName*/
        }
    }
}
