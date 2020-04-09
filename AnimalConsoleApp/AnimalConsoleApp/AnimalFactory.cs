using System;
using System.Collections;
using System.Diagnostics;

namespace AnimalConsoleApp
{
    public class AnimalFactory
    {
        public IAnimal Create(AnimalTypes animalType, string name)
        {
            switch (animalType)
            {
                case AnimalTypes.Dog:
                    return new Dog(name);
                case AnimalTypes.Cat:
                    return new Cat(name);
                case AnimalTypes.Elephant:
                    return new Elephant(name);
                case AnimalTypes.Fish:
                    return new Fish(name);
            }

            return null;
        } 
    }
}