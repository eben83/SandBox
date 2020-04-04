namespace AnimalConsoleApp
{
    public class Elephant : Animal, IAnimal
    {
        public Elephant(string name) : base(name)
        {
        }

        public override AnimalTypes Type
        {
            get { return AnimalTypes.Elephant; }
        }
        public string Identification { get; set; }
    }
}