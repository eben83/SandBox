using System;
using System.Collections.Generic;

namespace AnimalConsoleApp
{
    public class UiEngine
    {
         public void Run()
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
         
         private void GetAndPerformAnimalAction(List<Animal> animals)
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
                     switch (animalActionSecondWord)
                     {
                         case "run":
                         {
                             animal.Run();
                             break;
                         }
                         case "sleep":
                         {
                             animal.Sleep();
                             break;
                         }
                         case "eat" :
                         {
                             animal.Eat();
                             break;
                         }
                         default:
                         {
                             break;
                         }
                     }
                 }
             }
         }
    }
}