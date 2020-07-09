namespace Bicycle.Data.Models
{
    public class Components
    {
        public int Id { get; set; }
        public BikeType BikeType { get; set; }
        public ComponentType ComponentType { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
}