using System;

namespace AnimalFarm.Core.Domain
{
    public class Dog : Animal
    {
       
        public Dog(string name) : base(name)
        {
            Type = AnimalTypes.Dog;
            HungryLevel = 10;
        }
        
        protected override void Run()
        {
            Console.WriteLine("Whoosh");
            Console.WriteLine($"Play time for a {Type}, {Type}'s love to run");
            Console.WriteLine("They are the happiest while running around");
            HungryLevel -= 5;
        }

        protected override void Eat()
        {
            Console.WriteLine("Burp");
            Console.WriteLine($"Look at this {Type}, how fast?");
            Console.WriteLine("How fast do they eat?");
            feeding();
        }

        protected override void Talk()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Bark!!");
            Console.WriteLine("Bark!!");
            HungryLevel -= 2;
        }
        public int feeding()
        {
            return HungryLevel += 10 - HungryLevel;
        }

    }
}