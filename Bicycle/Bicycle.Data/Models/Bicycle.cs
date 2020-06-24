namespace Bicycle.Data.Models
{
    public class Bicycle
    {
        public int Id { get; set; }
        public BicycleType BicyleType { get; set; }
        public string BicycleMake { get; set; }
        public string BicycleModel { get; set; }
        public GearSetMake GearSetMake { get; set; }
        public string GearSet { get; set; }
        public WheelSetType WheelSetType { get; set; }
        public string WheelSetMake { get; set; }
        public int Weight { get; set; }
    }
}