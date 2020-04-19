using System;

namespace AnimalConsoleApp
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
            Type = AnimalTypes.Cat;
        }

        protected override void Run()
        {
            Console.WriteLine("Whoosh");
            Console.WriteLine($"Play time for a {Type}, {Type}'s love to run");
            Console.WriteLine("They are the happiest while running around");
        }
        protected override void Eat()
        {
            Console.WriteLine("Burp");
            Console.WriteLine($"I think you never feed your own {Type}");
            Console.WriteLine($"You probably feed everyone else's {Type}'s ");
        }
        protected override void Talk()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Meow!!");    
            Console.WriteLine("Meow!!");
        }

    }
}
