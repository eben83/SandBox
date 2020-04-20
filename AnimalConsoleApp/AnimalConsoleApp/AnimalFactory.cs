using System;

namespace AnimalConsoleApp
{
    public class AnimalFactory
    {
        public static Animal CreateAnimal(AnimalTypes animal, string name)
        {
            switch (animal)
            {
                case AnimalTypes.Dog:
                    return new Dog(name);
                case AnimalTypes.Cat:
                    return new Cat(name);
                case AnimalTypes.Elephant:
                    return new Elephant(name);
                case AnimalTypes.Salmon:
                    return new Salmon(name);
                case AnimalTypes.Penguin:
                    return new Penguin(name);
                case AnimalTypes.Eagle:
                    return new Eagle(name);
                default:
                    throw new ArgumentOutOfRangeException(nameof(animal), animal, null);
            }
        }
    }
}