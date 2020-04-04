namespace AnimalConsoleApp
{
    public class Dog : Animal, IAnimal
    {
        public Dog(string name) : base(name)
        {
        }

        public override AnimalTypes Type
        {
            get { return AnimalTypes.Dog; }
        }
        public string Identification { get; set; }
    }
}