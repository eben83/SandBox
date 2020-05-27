using System;

namespace AnimalFarm.Core.Domain
{
    public class Penguin : Animal
    {
        public Penguin(string name) : base(name)
        {
            Type = AnimalTypes.Penguin;
            HungryLevel = 10;
        }


        protected override void Run()
        {
            Console.WriteLine("Whoosh");
            Console.WriteLine($"HAHAHAHAHAHAHAH");
            Console.WriteLine($"Do {Type}'s even have knees");
            HungryLevel -= 3;
        }

        protected override void Eat()
        {
            Console.WriteLine("Burp");
            Console.WriteLine($"They are very quick to catch fish, ");
            Console.WriteLine($"{Type}'s are very at catching fish");
            HungryLevel += 6;
        }

        protected override void Fly()
        {
            Console.WriteLine("Flap");
            Console.WriteLine("Flap");
            base.Fly();
            feeding();
        }

        protected override void Talk()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Sneeze!!");
            Console.WriteLine("Sneeze!!");
            HungryLevel -= 1;
        }
        public int feeding()
        {
            return HungryLevel += 10 - HungryLevel;
        }


    }
}