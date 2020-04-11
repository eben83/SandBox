namespace AnimalConsoleApp.Other
{
    public class Cat : AnimalAbstract, IAnimal
    {
        public Cat(string name) : base(name)
        {
        }

        public override string Type => "Cat"; //lamda expression
        public string Identification { get; set; }
    }
}
