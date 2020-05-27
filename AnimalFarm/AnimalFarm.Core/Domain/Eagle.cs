using System;

namespace AnimalFarm.Core.Domain
{
    public class Eagle : Animal
    {
        public Eagle(string name) : base(name)
        {
            Type = AnimalTypes.Eagle;
            HungerLevel = 10;
        }
        
        protected override void Run()
        {
            Console.WriteLine("Whoosh");
            Console.WriteLine($"Why? why would you think this");
            Console.WriteLine($"{Type} they don't need to run..");
            HungerLevel -= 2;
        }
        protected override void Eat()
        {
            Console.WriteLine("Burp");
            Console.WriteLine($"If you have a weak tummy");
            Console.WriteLine("You better look away");
            FeedingTime();
        }
        protected override void Fly()
        {
            Console.WriteLine("Is it a bird?");
            Console.WriteLine("Is it a Plane?");
            Console.WriteLine($"It's a {Type}");
            HungerLevel -= 6;
        }
        protected override void Talk()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Scream!!");    
            Console.WriteLine("Scream");
            HungerLevel -= 2;
        }
        public int FeedingTime()
        {
            return HungerLevel += 10 - HungerLevel;
        }
    }
}