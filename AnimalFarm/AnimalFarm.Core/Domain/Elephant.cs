using System;

namespace AnimalFarm.Core.Domain
{
    public class Elephant : Animal
    {
        public Elephant(string name) : base(name)
        {
            Type = AnimalTypes.Elephant;
            HungryLevel = 10;
        }
        
        protected override void Run()
        {
            Console.WriteLine("Whoosh");
            Console.WriteLine($"You might think- because of their size, they are slow.");
            Console.WriteLine($"Guess again, {Type}'s are a lot quicker than you think.");
            HungryLevel -= 7;
        }
        protected override void Eat()
        {
            Console.WriteLine("Burp");
            Console.WriteLine($"This time, an {Type} can eat, they will devour ");
            Console.WriteLine("A whole tree by themselves");
            FeedingTime();
        }
        protected override void Talk()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Trumpet!!");    
            Console.WriteLine("Trumpet!!");
            HungryLevel -= 4;
        }
        public int FeedingTime()
        {
            return HungryLevel += 10 - HungryLevel;
        }

    }
}
