namespace AnimalConsoleApp
{
    public interface IAnimal
    {
        string Type { get; set; }
        string Name { get; set; }

        public void Run();

        public void Eat();

        public void Sleep();
    }
}