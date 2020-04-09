using System.Collections;
using System.Diagnostics;

namespace AnimalConsoleApp
{
    public class AnimalFactory: IAnimal
    {
        static void Create(AnimalTypes animalTypes)
        {
        }

        public AnimalTypes Type { get; set; }
        public string Name { get; set; }
        public string Identification { get; set; }
        public void Run()
        {
            throw new System.NotImplementedException();
        }

        public void Eat()
        {
            throw new System.NotImplementedException();
        }

        public void Sleep()
        {
            throw new System.NotImplementedException();
        }
    }
}