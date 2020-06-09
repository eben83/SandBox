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

        
        //ctor
        public List(ICarData _carData)
        {
            this._carData = _carData;
        }
        
        //the onGet responds to the http get
        public void OnGet()
        {
            
        }
    }
}