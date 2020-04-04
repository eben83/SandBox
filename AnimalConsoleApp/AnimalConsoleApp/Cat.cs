namespace AnimalConsoleApp
{
    public class Cat : Animal, IAnimal
    {
        public Cat(string name) : base(name)
        {
        }

        public override AnimalTypes Type
        {
            get { return AnimalTypes.Cat; }
        }
        public string Identification { get; set; }
    }
}