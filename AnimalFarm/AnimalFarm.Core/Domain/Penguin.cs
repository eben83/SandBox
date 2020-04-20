using System;

namespace AnimalFarm.Core.Domain
{
    public class Penguin : Animal
    {
    
        public Penguin(string name) : base(name)
        {
            Type = AnimalTypes.Penguin;
        }


        protected override void Run()
        {
            Console.WriteLine("Whoosh");
            Console.WriteLine($"HAHAHAHAHAHAHAH");
            Console.WriteLine($"Do {Type}'s even have knees");
        }

        protected override void Eat()
        {
            Console.WriteLine("Burp");
            Console.WriteLine($"They are very quick to catch fish, ");
            Console.WriteLine($"{Type}'s are very at catching fish");
        }

        protected override void Fly()
        {
            Console.WriteLine("Flap");
            Console.WriteLine("Flap");
            base.Fly();
        }

        protected override void Talk()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Sneeze!!");
            Console.WriteLine("Sneeze!!");
        }


        }
}