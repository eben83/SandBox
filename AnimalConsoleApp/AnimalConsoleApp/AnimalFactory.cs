using System;

namespace AnimalConsoleApp
{
    public class AnimalFactory
    {
        public static Animal CreateAnimal(AnimalTypes animalTypes, string animalName)
        {
            switch (animalTypes)
            {
                case AnimalTypes.Dog:
                    return new Dog(animalName);
                case AnimalTypes.Cat:
                    return new Cat(animalName);
                case AnimalTypes.Elephant:
                    return new Elephant(animalName);
                case AnimalTypes.Salmon:
                    return new Salmon(animalName);
                case AnimalTypes.Penguin:
                    return new Penguin(animalName);
                case AnimalTypes.Eagle:
                    return new Eagle(animalName);
                default:
                    throw new ArgumentOutOfRangeException(nameof(animalTypes), animalTypes, null);
            }
        }
        public Animal LetTheMagicHappen(AnimalTypes animalTypes, string animalName)
        {
            return CreateAnimal(animalTypes, animalName);
        }
    }
    
}