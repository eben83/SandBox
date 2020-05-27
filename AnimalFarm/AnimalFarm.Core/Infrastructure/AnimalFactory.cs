using System;
using AnimalFarm.Core.Domain;

namespace AnimalFarm.Core.Infrastructure
{
    public static class AnimalFactory
    {
        public static Animal CreateAnimal(AnimalTypes animalTypes, string animalName)
        {
            switch (animalTypes)
            {
                case AnimalTypes.Dog:
                    Animal.Hungry = 10;
                    return new Dog(animalName);
                case AnimalTypes.Cat:
                    Animal.Hungry = 10;
                    return new Cat(animalName);
                case AnimalTypes.Elephant:
                    Animal.Hungry = 10;
                    return new Elephant(animalName);
                case AnimalTypes.Salmon:
                    Animal.Hungry = 10;
                    return new Salmon(animalName);
                case AnimalTypes.Penguin:
                    Animal.Hungry = 10;
                    return new Penguin(animalName);
                case AnimalTypes.Eagle:
                    Animal.Hungry = 10;
                    return new Eagle(animalName);
                default:
                    throw new ArgumentOutOfRangeException(nameof(animalTypes), animalTypes, null);
            }
        }
    }
}