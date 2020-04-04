namespace AnimalConsoleApp
{
    public class Fish : Animal, IAnimal
    {
        public Fish(string name) : base(name)
        {
        }

        public AnimalTypes Type { get; set; }
        public string Identification { get; set; }
    }
}