namespace AnimalConsoleApp.Other
{
    public class Dog : AnimalAbstract, IAnimal
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