using System;

namespace Bicycle.Data.Models
{
    public class Bicycle
    {
        public int Id { get; set; }
        public BicycleType BicycleType { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public GearSet GearSet { get; set; }
        public GearSetModel GearSetModel { get; set; }
        public WheelSet WheelSet { get; set; }
        public WheelSetModel WheelSetModel { get; set; }
        public float Weight { get; set; }
    }
}