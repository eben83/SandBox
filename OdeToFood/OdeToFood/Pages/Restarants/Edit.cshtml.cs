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
            if(ModelState.IsValid)
            {
                restaurantData.Update(Restarant);
                restaurantData.Commit();
            }

            Cuisines = HtmlHelper.GetEnumSelectList<CuisineType>();
            return Page();
        }
    }
}
