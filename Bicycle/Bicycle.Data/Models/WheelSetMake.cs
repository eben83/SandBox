using System.ComponentModel.DataAnnotations;

namespace Bicycle.Data.Models
{
    public class WheelSetMake
    {
        
        [Display(Name = "Wheel Set Name")]
        public string Name { get; set; }
        
        [Display(Name = "Wheel Set Model")]
        public string Model { get; set; }
        
        [Display(Name = "Wheel Set Weight")]
        public int Weight { get; set; }
    }
}