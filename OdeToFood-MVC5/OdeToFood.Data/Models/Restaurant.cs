using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace OdeToFood.Data.Models
{
    public class Restaurant
    {
        public int Id { get; set; }


        [Required] 
        public string Name { get; set; }
        
        [Display(Name= "Type of Food")]
        public CuisineType Cuisine { get; set; }
    }
}