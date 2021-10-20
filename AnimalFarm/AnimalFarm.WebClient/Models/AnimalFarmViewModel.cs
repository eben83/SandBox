using System;
using System.Collections.Generic;
using AnimalFarm.Core.Domain;

namespace AnimalFarm.WebClient.Models
{
    public class AnimalFarmViewModel
    {
        public List<Animal> Animals { get; set; }

        public AnimalFarmViewModel()
        {
            Animals = new List<Animal>();
        }
        
    }
}