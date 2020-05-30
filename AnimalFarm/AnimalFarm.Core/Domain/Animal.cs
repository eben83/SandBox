using System;

namespace AnimalFarm.Core.Domain
{
    public abstract class Animal
    {
        public AnimalTypes Type { get; set; }
        public string Name { get; set; }
        public int HungerLevel { get; set; }
        public string Identification
        {
            get { return $" {Type} - {Name} - {GetHungerLevel()}"; }
        }
        public Animal(string name)
        {
            Name = name;
            HungerLevel = 10;
        }
        public string GetHungerLevel()
        {
            if (HungerLevel == 10)
            {
                return "Full- lets go play";
            }
            else if (HungerLevel >=8)
            {
                return "I'm fine- let's do that again";
            }
            else if (HungerLevel >= 6)
            {
                return "I could do with a snack";
            }
            else if (HungerLevel >= 3)
            {
                return "I need food please";
            }
            else if (HungerLevel <= 3)
            {
                return "I'm not playing anymore";
            }
            
            return null;
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
        public void Feed()
        {
            HungerLevel = 10;
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