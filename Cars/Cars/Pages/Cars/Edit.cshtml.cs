using CarsLibrary.Core;
using CarsLibrary.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cars.Pages.Cars
{
    public class Edit : PageModel
    {
        //field
        private readonly ICarData _carData;
        
        //property
        public Car Car { get; set; }
        
        public Edit(ICarData carData)
        {
            this._carData = carData;
        }
        
        public IActionResult OnGet(int carId)
        {
            Car = _carData.GetById(carId);
            if (Car == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }
    }
}