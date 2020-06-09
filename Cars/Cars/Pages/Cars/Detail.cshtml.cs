using CarsLibrary.Core;
using CarsLibrary.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cars.Pages.Cars
{
    public class Detail : PageModel
    {
        private ICarData carData;
        public Car Car { get; set; }

        //ctor
        public Detail(ICarData carData)
        {
            this.carData = carData;
        }
        public void OnGet(int carId)
        {
            //saying that the car must equal the car id
            Car = carData.GetById(carId);
        }
    }
}