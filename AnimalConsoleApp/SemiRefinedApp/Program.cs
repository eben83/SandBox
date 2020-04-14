using System;
using System.Collections.Generic;

namespace SemiRefinedApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            
        }
    }
    
    public class Animal
    {
        public string Type { get; set; }
        public string Name { get; set; }

        public string Identification
        {
            get { return $"{Type} - {Name}"; }
            
        }
        
        public Animal(string name)
        {
            Name = name;
        }

        public void Run()
        {
            Console.WriteLine("Doof, doof, doof");
            Console.WriteLine("Look at him go!");
            Console.WriteLine("Feeling the earth moving!!");
            Console.WriteLine($"{Type} stops Running. He looks quite Hungry");
            Console.WriteLine($"{Identification} is running....");
            Console.WriteLine("And tired now.");
            Console.WriteLine();
        }

        public void Eat()
        {
            Console.WriteLine($"{Identification} is eating...");
            Console.WriteLine("Munch, munch, munch");
            Console.WriteLine("Look at all that food go down!!!");
            Console.WriteLine("Burp!!"); 
            Console.WriteLine();
        }

        public void Sleep()
        {
            Console.WriteLine($"{Identification} is sleeping...");
            Console.WriteLine("ZZzzZZZzzzZZz");
            Console.WriteLine("How loud can he snore!!!");
            Console.WriteLine($"{Type} can sleep all day");
        }

        public void Fly()
        {
            Console.WriteLine("Is it a bird?!");
            Console.WriteLine("Is it a plane?!");
            Console.WriteLine($"It's a {Type}!!");
        }

        public void DogTalk()
        {
            Console.WriteLine("Bark!!");
            Console.WriteLine("Bark!!");
        }

        public void CatTalk()
        {
            Console.WriteLine("Meow");
            Console.WriteLine("Meow");
        }

        public void ElephantTalk()
        {
            Console.WriteLine("Trumpet!!!!");
            Console.WriteLine("Trumpet!!!!");
        }

        public void FishTalk()
        {
            Console.WriteLine("Bubble");
            Console.WriteLine("Bubble");
        }

        public void PenguinTalk()
        {
            Console.WriteLine("Gak!");
            Console.WriteLine("Gak!!");
        }
    }
}


