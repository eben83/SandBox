using System;

namespace AnimalConsoleApp
{
    public class Salmon : Animal
    {
        public Salmon(string name) : base(name)
        {
            Type = AnimalTypes.Salmon;
        }
        
        protected override void Run()
        {
            Console.WriteLine("Whoosh");
            Console.WriteLine($"Well, this type of run, Is not what you expect");
            Console.WriteLine($"Once a year there is something called a {Type} run");
        }
        protected override void Eat()
        {
            Console.WriteLine("Burp");
            Console.WriteLine($"Do {Type} even eat");
            Console.WriteLine("This might be one of the seven wonders of the world");
        }
        protected override void Talk()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Bubble!!");    
            Console.WriteLine("Bubble!!");
        }

    }
}