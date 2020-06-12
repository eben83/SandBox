using CarsLibrary.Core;
using CarsLibrary.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cars.Pages.Cars
{
    public class Delete : PageModel
    {
        private readonly ICarData _carData;

        public Car Car { get; set; }
        
        public Delete(ICarData carData)
        {
            _carData = carData;
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

        public IActionResult onPost(int carId)
        {
            var car = _carData.Delete(carId);
            _carData.Commit();

            if (car == null)
            {
                return RedirectToPage("./NotFound");
            }

            TempData["Message"] = $"{car.Make} deleted";
            return RedirectToPage("./List");
        }
    }
}