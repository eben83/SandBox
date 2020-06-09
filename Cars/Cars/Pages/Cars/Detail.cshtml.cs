using CarsLibrary.Core;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cars.Pages.Cars
{
    public class Detail : PageModel
    {
        public Car Car { get; set; }
        
        public void OnGet()
        {
            
        }
    }
}