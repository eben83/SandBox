using CarsLibrary.Data;
using Microsoft.AspNetCore.Mvc;

namespace Cars.ViewComponents
{
    public class CarCountViewComponent : ViewComponent
    {
        private readonly ICarData _carData;

        //ctor
        public CarCountViewComponent(ICarData carData)
        {
            _carData = carData;
        }

        
        //returns a view- 
        public IViewComponentResult Invoke()
        {
            var count = _carData.GetCountOfCars();
            return View(count);
        }
    }
}