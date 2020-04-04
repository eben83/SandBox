using System;

namespace AnimalConsoleApp
{
    // this is a complex class
    public abstract class Animal
    {
        public virtual string Type { get; set; }
        public string Name { get; set; }

        public string Identification
        {
            get { return $"{Type} - {Name}"; }
        }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void Run()
        {
            Console.WriteLine($"{Type} is running....");
            Console.WriteLine("doof, doof, doof");
            Console.WriteLine("Look at him go!");
            Console.WriteLine("Feeling the earth moving!!");
            Console.WriteLine($"{Type} stops Running. He looks quite Hungry");
            Console.WriteLine("and tired now.");
            Console.WriteLine();
        }

        public virtual void Eat()
        {
            Console.WriteLine($"{Type} is eating...");
            Console.WriteLine("munch, munch, munch");
            Console.WriteLine("Look at all that food go down!!!");
            Console.WriteLine("Burp!!"); 
            Console.WriteLine();
        }

        public void Sleep()
        {
            Console.WriteLine($"{Type} is sleeping...");
            Console.WriteLine("ZZzzZZZzzzZZz");
            Console.WriteLine("how loud can he snore!!!");
            Console.WriteLine("Cats can sleep all day");
        }
    }
}
