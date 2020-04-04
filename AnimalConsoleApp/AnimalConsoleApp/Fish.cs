namespace AnimalConsoleApp
{
    public class Fish : Animal, IAnimal
    {
        public Fish(string name) : base(name)
        {
        }

        public override AnimalTypes Type
        {
            get { return AnimalTypes.Fish; }
        }
        public string Identification { get; set; }
    }
}