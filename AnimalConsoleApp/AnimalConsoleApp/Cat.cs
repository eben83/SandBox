namespace AnimalConsoleApp
{
    public class Cat : Animal, IAnimal
    {
        public Cat(string name) : base(name)
        {
        }

        public override string Type => "Cat"; //lamda expression
        public string Identification { get; set; }
    }
}
