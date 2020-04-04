namespace AnimalConsoleApp
{
    public class Dog : Animal, IAnimal
    {
        public Dog(string name) : base(name)
        {
        }

        public AnimalTypes Type { get; set; }
        public string Identification { get; set; }
    }
}