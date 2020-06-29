using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bicycle.Data.Models
{
    public class Bike
    {
        public int Id { get; set; }
        
        [Display(Name ="Bike Type")]
        public BikeType BikeType { get; set; }
        
       [Display(Name = "Bike Make")]
        public string BikeMake { get; set; }
        
        [Display(Name = "Bike Model")]
        public string BikeModel { get; set; }
        
        public GearSetMake GearSetMake { get; set; }
        
        [Display(Name = "Gear Set")]
        public GearSet GearSet { get; set; }
        
        [Display(Name = "Wheel Set Type")]
        public WheelSetType WheelSetType { get; set; }
        
        
        public WheelSetMake WheelSetMake { get; set; }
        
        [Display(Name = "Bike Weight")]
        public int Weight { get; set; }
    }
}