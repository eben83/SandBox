namespace AnimalConsoleApp
{
    public class Elephant : Animal, IAnimal
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