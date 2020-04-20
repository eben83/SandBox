using System;

namespace AnimalFarm.Core.Domain
{
    public abstract class Animal
    {
        public AnimalTypes Type { get; set; }
        public string Name { get; set; }
        public string Identification
        {
            get { return $" {Type} - {Name}"; }
        }
        public Animal(string name)
        {
            Name = name;
        }
        public void Command(AnimalActions animalAction)
        {
            switch(animalAction)
            {
                case AnimalActions.Run:
                    Run();
                    break;
                case AnimalActions.Eat:
                    Eat();
                    break;
                case AnimalActions.Sleep:
                    Sleep();
                    break;
                case AnimalActions.Fly:
                    Fly();
                    break;
                case AnimalActions.Talk:
                    Talk();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(animalAction), "Use the enum directly"); 
            }
        }
        protected virtual void Run()
        {
            Console.WriteLine("Animal is running");
        }
        //protected- access is limited
        protected virtual void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
        private void Sleep()
        {
            Console.WriteLine("Animal is Sleeping");
        }
        protected virtual void Fly()
        {
            if (Type != AnimalTypes.Eagle)
            {
                Console.WriteLine("Really?! Whatever");
                return;
            }
            Console.WriteLine("Animal is Flying");
        }
        protected virtual void Talk()
        {
            Console.WriteLine("Animal is Talking");
        }
       
    }
}