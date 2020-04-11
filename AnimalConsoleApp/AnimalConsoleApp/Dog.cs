namespace AnimalConsoleApp
{
    public class Dog : Animal, IAnimal
    {
        public Dog(string name) : base(name)
        {
        }

        public override string Type
        {
            get { return "Dog"; }
        }
        public string Identification { get; set; }
    }
}