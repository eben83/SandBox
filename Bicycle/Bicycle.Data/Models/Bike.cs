namespace Bicycle.Data.Models
{
    public class Bike
    {
        public int Id { get; set; }
        public string BikeType { get; set; }
        public string BikeMake { get; set; }
        public string BikeModel { get; set; }
        public string GearSetMake { get; set; }
        public string GearSet { get; set; }
        public string WheelSetType { get; set; }
        public string WheelSetMake { get; set; }
        public int Weight { get; set; }
    }
}