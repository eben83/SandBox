namespace AnimalConsoleApp
{
    public class Cat : Animal, IAnimal
    {
        public Cat(string name) : base(name)
        {
        }

        public AnimalTypes Type { get; set; }
        public string Identification { get; set; }
    }
}