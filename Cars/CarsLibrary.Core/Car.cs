using System.ComponentModel.DataAnnotations;

namespace CarsLibrary.Core
{
    public class Car
    {
        public int Id { get; set; }
        [Required]
        public string Model { get; set; }
        public string Make { get; set; }
        public string Colour { get; set; }
        public CarType carType { get; set; }
    }
}