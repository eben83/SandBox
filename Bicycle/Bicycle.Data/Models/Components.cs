using System.ComponentModel.DataAnnotations;

namespace Bicycle.Data.Models
{
    public class Components
    {
        public int Id { get; set; }
        [Display(Name = "Bike Type")]
        public BikeType BikeType { get; set; }
        
        [Display(Name = "Component")]
        public ComponentType ComponentType { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
}