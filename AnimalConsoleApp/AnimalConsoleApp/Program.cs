﻿
using System;
using System.Linq;
using System.Xml;

namespace AnimalConsoleApp
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to my Animal App");
            Console.WriteLine();
            
            Console.WriteLine("Please enter your name");
            var name = Console.ReadLine();

            Console.WriteLine($"Top of the morning to ya, {name}");
            Console.WriteLine();

            Console.WriteLine("Name any amount of animals you like:");
            var animals = Console.ReadLine();
            var animalsArray = animals.Split(",");

            Console.WriteLine("Enter as many names as you wish:");
            var names = Console.ReadLine();
            var namesArray = names.Split(",");

            Console.WriteLine();
            
            Console.WriteLine("You entered the following choices");
            for (int i = 0; i < animalsArray.Length; i++)
            {
                
                Console.WriteLine($"{animalsArray[i]} - {namesArray[i]}");
            }

            Console.WriteLine();

            Console.WriteLine("Animals can do the following:");
            Console.WriteLine("Run, Sleep, Eat");
            Console.WriteLine();
            Console.WriteLine("Specify the animal and action you want to perform:");
            Console.WriteLine("Example: Elephant - Run / ELEPHANT-RUN / Elephant- Run / Elephant - RUN");
            var elephantAction = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Elephant is running....");
            Console.WriteLine("doof, doof, doof");
            Console.WriteLine("Look at him go!");
            Console.WriteLine("Feeling the earth moving!!");
            Console.WriteLine("Elephant stops Running. He looks quite Hungry");
            Console.WriteLine("and tired now.");
            Console.WriteLine();
            Console.WriteLine("Press enter to carry on.");
            Console.ReadKey();

            Console.WriteLine("Specify another animal and action you want to perform:");
            Console.WriteLine("Example: Dog - Eat / DOG-EAT / Dog- Eat");
            var dogAction = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Dog is eating...");
            Console.WriteLine("munch, munch, munch");
            Console.WriteLine("Look at all that food go down!!!");
            Console.WriteLine("Burp!!");
            Console.WriteLine();
            Console.WriteLine("press enter to carry on.");
            Console.ReadKey();

            Console.WriteLine("Specify yet another animal and action you want to perform:");
            Console.WriteLine("Example: Cat - Sleep / CAT-SlEEP / Cat- Sleep");
            var catAction = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Cat is sleeping...");
            Console.WriteLine("ZZzzZZZzzzZZz");
            Console.WriteLine("how loud can he snore!!!");
            Console.WriteLine("Cats acn sleep all day");

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