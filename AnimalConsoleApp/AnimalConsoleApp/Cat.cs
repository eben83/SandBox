namespace AnimalConsoleApp
{
    public class Cat : Animal, IAnimal
    {
        public Cat(string name) : base(name)
        {
        }

        public override AnimalTypes Type => AnimalTypes.Cat; //lamda expression
        public string Identification { get; set; }
    }
}
