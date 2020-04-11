namespace AnimalConsoleApp.Other
{
    public class Fish : AnimalAbstract, IAnimal
    {
        public Fish(string name) : base(name)
        {
        }

        public override string Type
        {
            get { return "Fish"; }
        }
        public string Identification { get; set; }
    }
}