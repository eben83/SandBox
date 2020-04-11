using System;

namespace AnimalConsoleApp
{
    public interface IAnimal
    {
        string  Type { get; set; }
        string Name { get; set; }
        string Identification { get; set; }

        void Run();
        void Eat();
        void Sleep();
    }
}