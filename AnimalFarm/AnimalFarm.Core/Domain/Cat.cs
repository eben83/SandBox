using System;

namespace AnimalFarm.Core.Domain
{
    public class Cat : Animal
    {

        public Cat(string name) : base(name)
        {
            Type = AnimalTypes.Cat;
            HungryLevel = 10;
        }
        
        protected override void Run()
        {
            Console.WriteLine("Whoosh");
            Console.WriteLine($"Running, They will rather watch");
            Console.WriteLine("You Run around");
            HungryLevel -= 3;
        }
        protected override void Eat()
        {
            Console.WriteLine("Burp");
            Console.WriteLine($"I think you never feed your own {Type}");
            Console.WriteLine($"You probably feed everyone else's {Type}'s ");
            FeedingTime();
        }
        protected override void Talk()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Meow!!");    
            Console.WriteLine("Meow!!");
            HungryLevel -= 1;
        }
        public int FeedingTime()
        {
            return HungryLevel += 10 - HungryLevel;
        }

    }
}
