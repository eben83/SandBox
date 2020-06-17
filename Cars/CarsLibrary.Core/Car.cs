using System.ComponentModel.DataAnnotations;

namespace CarsLibrary.Core
{
    public class Car
    {
        public int Id { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Colour { get; set; }
        [Required]
        public CarType carType { get; set; }
    }
}