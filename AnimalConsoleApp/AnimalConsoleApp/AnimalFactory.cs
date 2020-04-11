using System;
using System.Collections;
using System.Diagnostics;

namespace AnimalConsoleApp
{
    public class AnimalFactory
    {
        public static IAnimal CreateIAnimal(string animalType, string name)
        {
            switch (animalType.ToLower())
            {
                case "dog":
                    return new Dog(name);
                case "cat":
                    return new Cat(name);
                case "elephant":
                    return new Elephant(name);
                case "fish":
                    return new Fish(name);
                default:
                    throw new Exception($"{animalType} is not supported.");
            }
        } 
    }
}