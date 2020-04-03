
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
            animalActionSecondWord = animalAction.Substring(animalAction.IndexOf("-"));

            foreach (var animal in animals)
            {
                if (animal.Type == animalActionFirstWord)
                {
                    if (animalActionSecondWord == "run")
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
            
            Console.WriteLine();
            
            Console.WriteLine("Animals can do the following:");
            Console.WriteLine("Run, Sleep, Eat");
            Console.WriteLine();
            Console.WriteLine("Specify the animal and action you want to perform:");
            Console.WriteLine("Example: Cat - Sleep / CAT-SLEEP / Cat- Sleep / Cat - SLEEP");
            animalAction = Console.ReadLine().ToLower().Replace(" ", "");
            animalActionFirstWord = animalAction.Substring(0, animalAction.IndexOf("-"));
            animalActionSecondWord = animalAction.Substring(animalAction.IndexOf("-")-1);

            foreach (var animal in animals)
            {
                if (animal.Type == animalActionFirstWord)
                {
                    if (animalActionSecondWord == "run")
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
            
            Console.WriteLine();
            
            Console.WriteLine("Animals can do the following:");
            Console.WriteLine("Run, Sleep, Eat");
            Console.WriteLine();
            Console.WriteLine("Specify the animal and action you want to perform:");
            Console.WriteLine("Example: Dog - Eat / DOG-EAT / Dog- Eat / Dog - EAT");
            animalAction = Console.ReadLine().ToLower().Replace(" ", "");
            animalActionFirstWord = animalAction.Substring(0, animalAction.IndexOf("-"));
            animalActionSecondWord = animalAction.Substring(animalAction.IndexOf("-")-1);

            foreach (var animal in animals)
            {
                if (animal.Type == animalActionFirstWord)
                {
                    if (animalActionSecondWord == "run")
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
            
            Console.WriteLine();

            
            Console.WriteLine();
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
            
            
            // var myAnimal = new Animal();

            // Console.WriteLine("Choose an animal");
            // myAnimal.nameOfAnimal = Console.ReadLine();

            // Console.WriteLine("How many legs does your animal have?");
            // myAnimal.numberOfLegs = Console.ReadLine();

            // Console.WriteLine("Can your animal fly?");
            // Console.WriteLine("True or false");

            // myAnimal.canAnimalFly = Convert.ToBoolean(Console.ReadLine());
            //
            
            // if (myAnimal.canAnimalFly == true)
            // {
            //     Console.WriteLine($"your animal can fly because its a {myAnimal.nameOfAnimal} " +
            //                       $" your animal has {myAnimal.numberOfLegs} legs");
            // }
            // else
            // {
            //     Console.WriteLine($"your animal is unable to fly, but your animal is a {myAnimal.nameOfAnimal} " +
            //                       $"and has {myAnimal.numberOfLegs} legs");
            // }
            //
            // Console.ReadKey();



            // Console.WriteLine("Choose an Animal ");
            // string nameOfAnimal = Console.ReadLine();
            //
            // Console.WriteLine("How many legs does your animal have? ");
            // string numberOfLegs = Console.ReadLine();
            //
            // Console.WriteLine($"your animal is a {nameOfAnimal} and has {numberOfLegs} legs");
            // Console.ReadKey();
        }
    }
}