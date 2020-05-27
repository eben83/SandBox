using System;

namespace AnimalFarm.Core.Domain
{
    public class Elephant : Animal
    {
        public int Hungry { get; set; } = 10;
        public Elephant(string name) : base(name)
        {
            Type = AnimalTypes.Elephant;
        }
        
        protected override void Run()
        {
            Console.WriteLine("Whoosh");
            Console.WriteLine($"You might think- because of their size, they are slow.");
            Console.WriteLine($"Guess again, {Type}'s are a lot quicker than you think.");
            Hungry -= 7;
        }
        protected override void Eat()
        {
            Console.WriteLine("Burp");
            Console.WriteLine($"This time, an {Type} can eat, they will devour ");
            Console.WriteLine("A whole tree by themselves");
            feeding();
        }
        protected override void Talk()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Trumpet!!");    
            Console.WriteLine("Trumpet!!");
            Hungry -= 4;
        }
        public int feeding()
        {
            return Hungry += 10 - Hungry;
        }

    }
}
