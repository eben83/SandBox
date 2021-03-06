using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OdeToFood.Data;
using OdeToFood.Core;


namespace OdeToFood.Pages.Restarants
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Restarant Restarant { get; set; }
        public IEnumerable<SelectListItem> Cuisines { get; set; }

        public IRestaurantData restaurantData { get; }
        public IHtmlHelper HtmlHelper { get; }

        public EditModel(IRestaurantData restaurantData,
                                IHtmlHelper htmlHelper)
        {
            this.restaurantData = restaurantData;
            this.HtmlHelper = htmlHelper;
        }

        

        public IActionResult OnGet(int? restarantId)
        {
            Cuisines = HtmlHelper.GetEnumSelectList<CuisineType>();

            /*below if the restarant has an ID- then it will return the value- if the id is null
             it will return a new intstance*/

            if (restarantId.HasValue)
            {
                Restarant = restaurantData.GetById(restarantId.Value);
            }
            else
            {
                Restarant = new Restarant();
            }

            if(Restarant == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }

        /*this is the save button event*/
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid) /*checks the validation is correct with the model binding.*/
            {
                Cuisines = HtmlHelper.GetEnumSelectList<CuisineType>();
                /*this will re build the selection option of the dropdown menu*/
                return Page();
            }

            if(Restarant.ID > 0)
            {
                restaurantData.Update(Restarant);
            }
            else
            {
                restaurantData.Add(Restarant);
            }

            
            restaurantData.Commit();
            TempData["Message"] = "Restaurant Saved!";
                /*TempData is just for tempe data and won't display again*/

            return RedirectToPage("./Detail", new { restarantId = Restarant.ID });
                /*POST-Get- Redirect method*/

        }
    }
}
