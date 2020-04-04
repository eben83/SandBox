namespace AnimalConsoleApp
{
    public class Elephant : Animal, IAnimal
    {
        public Elephant(string name) : base(name)
        {
        }

        public AnimalTypes Type { get; set; }
        public string Identification { get; set; }
    }
}