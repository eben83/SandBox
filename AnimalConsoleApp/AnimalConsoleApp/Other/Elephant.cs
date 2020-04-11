namespace AnimalConsoleApp.Other
{
    public class Elephant : AnimalAbstract, IAnimal
    {
        public Elephant(string name) : base(name)
        {
        }

        public override string Type
        {
            get { return "Elephant"; }
        }
        public string Identification { get; set; }
    }
}