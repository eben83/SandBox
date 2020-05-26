using System;

namespace AnimalFarm.Core.Domain
{
    public abstract class Animal
    {
        public AnimalTypes Type { get; set; }
        public string Name { get; set; }
        public static int Hungry { get; set; } = 10;
        public string Identification
        {
            get { return $" {Type} - {Name} Hunger: {HungerLevel()}"; }
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
        public string HungerLevel ()
        {
            var food = "";
            if (Hungry == 10)
            {
                food = $"I'm Full, lets do something!!";
                
            }
            else if (Hungry >= 5)
            {
                food = $"I could do with a snack";
            }
            else if (Hungry <= 3)
            {
                food = $"I'm hungry, I need something to eat";
            }
            else
            {
                food = $"I'm not going to do anything until I eat!!!";
            }
            return food;
        }
        public int feeding()
        {
            return Hungry += 10 - Hungry;
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
            Hungry -= 3;
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