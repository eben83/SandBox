using System.Collections.Generic;
using CarsLibrary.Core;
using CarsLibrary.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cars.Pages.Cars
{
    public class Edit : PageModel
    {
        //field
        private readonly ICarData _carData;
        private readonly IHtmlHelper _htmlHelper;

        //property
        [BindProperty]
        public Car Car { get; set; }
        public IEnumerable<SelectListItem> Cars { get; set; }
        
        public Edit(ICarData carData, IHtmlHelper htmlHelper)
        {
            this._carData = carData;
            _htmlHelper = htmlHelper;
        }
        
        public IActionResult OnGet(int? carId)
        {
            Cars = _htmlHelper.GetEnumSelectList<CarType>();
            if (carId.HasValue)
            {
                Car = _carData.GetById(carId.Value);
            }
            else
            {
                Car = new Car();
            }
            if (Car == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Car = _carData.update(Car);
                _carData.Commit();
                return RedirectToPage("./Detail", new {carId = Car.Id});
            }
            
            //will display the info on the post
            Cars = _htmlHelper.GetEnumSelectList<CarType>();
            
            
            return Page();
        }
    }
}