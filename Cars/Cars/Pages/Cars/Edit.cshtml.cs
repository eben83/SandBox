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
            _carData = carData;
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
            //not valid- return page to fix
            if (!ModelState.IsValid)
            {
                //will display the info on the post
                Cars = _htmlHelper.GetEnumSelectList<CarType>();
                return Page();
            }

            if (Car.Id > 0)
            { 
                _carData.update(Car);
            }
            else
            {
                _carData.Add(Car);
            }
            
            //update the car object
            _carData.Commit();
            //temporary data- for the message
            TempData["Message"] = "Your car was saved!";
            return RedirectToPage("./Detail", new {carId = Car.Id});
            
        }
    }
}