
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace AnimalConsoleApp
{

    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();


            Console.WriteLine("Welcome to my Animal App");
            Console.WriteLine();

            Console.WriteLine("Please enter your name");
            var name = Console.ReadLine();

            Console.WriteLine($"Top of the morning to ya, {name}");
            Console.WriteLine();

            Console.WriteLine("Name any amount of animals you like:");
            var animalTypes = Console.ReadLine().Split(",");

            foreach (var animalType in animalTypes)
            {
                var animal = new Animal();
                animal.Type = animalType;
                animals.Add(animal);
            }

            Console.WriteLine("Enter as many names as you wish:");
            var names = Console.ReadLine().Split(",");

            for (int index = 0; index < animals.Count; index++)
            {
                animals[index].Name = names[index];

            }

            Console.WriteLine();

            Console.WriteLine($"You entered the following choices (Total {animals.Count})");

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Identification}");
            }

            Console.WriteLine();

            GetAndPerformAnimalAction(animals);
            GetAndPerformAnimalAction(animals);
            GetAndPerformAnimalAction(animals);
            
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }

        private static void GetAndPerformAnimalAction(List<Animal> animals)
        {
            string animalAction;
            string animalActionFirstWord;
            string animalActionSecondWord;

            Console.WriteLine("Animals can do the following:");
            Console.WriteLine("Run, Sleep, Eat");
            Console.WriteLine();
            Console.WriteLine("Specify the animal and action you want to perform:");
            Console.WriteLine("Example: Elephant - Run / ELEPHANT-RUN / Elephant- Run / Elephant - RUN");
            animalAction = Console.ReadLine().ToLower().Replace(" ", "");
            animalActionFirstWord = animalAction.Substring(0, animalAction.IndexOf("-"));
            animalActionSecondWord = animalAction.Substring(animalAction.IndexOf("-") + 1);

            foreach (var animal in animals)
            {
                if (string.Compare(animal.Type, animalActionFirstWord, StringComparison.InvariantCultureIgnoreCase) ==
                    0)
                {
                    if (string.Compare(animalActionSecondWord, "run", StringComparison.InvariantCultureIgnoreCase) == 0)
                    {
                        animal.Run();
                    }

                    if (animalActionSecondWord == "sleep")
                    {
                        animal.Sleep();
                    }

                    if (animalActionSecondWord == "eat")
                    {
                        animal.Eat();
                    }
                }
            }
        }
    }
}
