﻿
using System;
using System.Linq;
using System.Xml;

namespace AnimalConsoleApp
{
    public class Animal
    {
        public string nameOfAnimal { get; set; }
        public string numberOfLegs { get; set; }
        public bool canAnimalFly { get; set; }

    }

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

            Console.WriteLine("Name three animals");
            var animals = Console.ReadLine();
            var animalsArray = animals.Split(",");

            Console.WriteLine("List three names");
            var names = Console.ReadLine();
            var namesArray = names.Split(",");
            
            for (int i = 0; i < animalsArray.Length; i++)
            {
                Console.WriteLine($"{animalsArray[i]} - {namesArray[i]}");
            }
            

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