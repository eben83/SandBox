using System;

namespace AnimalConsoleApp
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
            Console.WriteLine($"Play time for a {Type}, {Type}'s love to run");
            Console.WriteLine("They are the happiest while running around");
        }

        protected override void Eat()
        {
            Console.WriteLine("Burp");
            Console.WriteLine($"Look at this {Type}, how fast?");
            Console.WriteLine("How fast do they eat?");
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
            Console.WriteLine("Bark!!");
            Console.WriteLine("Bark!!");
        }


        }
}