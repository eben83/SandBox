using System.ComponentModel.DataAnnotations;

namespace AnimalFarm.WebClient.Models
{
    public class AddAnimalViewModel
    {
        public int SelectedAnimalType { get; set; }
        
        public string AnimalName { get; set; }
        
    }
}