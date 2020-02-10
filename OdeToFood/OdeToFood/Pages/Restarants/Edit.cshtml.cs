using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OdeToFood.Data;

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

        

        public IActionResult OnGet(int restarantId)
        {

            Cuisines = HtmlHelper.GetEnumSelectList<CuisineType>();

            Restarant = restaurantData.GetById(restarantId);

            if(Restarant == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid) /*checks the validation is correct with the model binding.*/
            {
                restaurantData.Update(Restarant);
                restaurantData.Commit();
                return RedirectToPage("./Detail", new {restarantId = Restarant.ID});
                /*POST-Get- Redirect method*/
            }

            Cuisines = HtmlHelper.GetEnumSelectList<CuisineType>();
            /*this will re build the selection option of the dropdown menu*/
            return Page();
        }
    }
}
