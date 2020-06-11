using CarsLibrary.Core;
using CarsLibrary.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cars.Pages.Cars
{
    public class Detail : PageModel
    {
        //field
        private ICarData carData;
        
        //property
        public Car Car { get; set; }
        [TempData]//will look for the TempData and display the message
        public string Message { get; set; }

        //ctor
        public Detail(ICarData carData)
        {
            this.carData = carData;
        }
        public IActionResult OnGet(int carId)
        {
            //saying that the car must equal the car id
            Car = carData.GetById(carId);
            if (Car == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }
    }
}