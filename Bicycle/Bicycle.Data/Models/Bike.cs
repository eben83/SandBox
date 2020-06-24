namespace Bicycle.Data.Models
{
    public class Bike
    {
        public int Id { get; set; }
        public BikeType BikeType { get; set; }
        public string BikeMake { get; set; }
        public string BikeModel { get; set; }
        public GearSetMake GearSetMake { get; set; }
        public GearSet GearSet { get; set; }
        public WheelSetType WheelSetType { get; set; }
        public WheelSetMake WheelSetMake { get; set; }
        public int Weight { get; set; }
    }
}