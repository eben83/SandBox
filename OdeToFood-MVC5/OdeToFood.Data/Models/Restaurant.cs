﻿using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace OdeToFood.Data.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        
        
        [Required]
        public string Name { get; set; }
        
       
        public CuisineType Cuisine { get; set; }
    }
}