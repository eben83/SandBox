using System.ComponentModel.DataAnnotations;

namespace Bicycle.Data.Models
{
    public class GearSet
    {
        [Display(Name = "Gear Set Model")]
        public string Model { get; set; }
        
        [Display(Name = "Gear Set Model Number")]
        public string ModelNumber { get; set; }
    }
}