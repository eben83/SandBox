using CarsLibrary.Core;
using CarsLibrary.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cars.Pages.Cars
{
    public class Delete : PageModel
    {
        private readonly ICarData _carData;
        
        public Car CarProp { get; set; }

        public Delete(ICarData carData)
        {
            _carData = carData;
        }

        public IActionResult OnGet(int carId)
        {
            CarProp = _carData.GetById(carId);
            if (CarProp == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }

        public IActionResult OnPost(int carId)
        {
            var car = _carData.Delete(carId);
            _carData.Commit();

            if (car == null)
            {
                return RedirectToPage("./NotFound");
            }

            TempData["message"] = $"{car.Model} deleted";
            return RedirectToPage("./List");
        }
    }
}