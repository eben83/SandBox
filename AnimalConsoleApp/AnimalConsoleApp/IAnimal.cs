namespace AnimalConsoleApp
{
    public interface IAnimal
    {
        string AnimalType { get; set; }
        string AnimalName { get; set; }

        public void Run(){}
        
        public void Eat(){}
        
        public void Sleep(){}
    }
}