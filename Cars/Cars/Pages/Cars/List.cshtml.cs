using System.Collections.Generic;
using CarsLibrary.Core;
using CarsLibrary.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Cars.Pages.Cars
{
    public class List : PageModel
    {
        //allows to access the app setting files
        private readonly IConfiguration config;
        private readonly ICarData _carData; //field

        //property- gets the Car class
        public IEnumerable<Car> Cars { get; set; }
        
        //ctor
        public List(ICarData _carData)
        {
            this._carData = _carData;
        }
        
        //the onGet responds to the http get
        public void OnGet(string searchTerm) //model binding
        {
            
            Cars = _carData.GetCarsByMake(searchTerm);
        }
    }
}