namespace Bicycle.Data.Models
{
    public class Bicycle
    {
        public int Id { get; set; }
        public string BicyleType { get; set; }
        public string BicycleMake { get; set; }
        public string GearSetMake { get; set; }
        public string GearSet { get; set; }
        public string WheelSetType { get; set; }
        public string WheelSetMake { get; set; }
        public float Weight { get; set; }
    }
}