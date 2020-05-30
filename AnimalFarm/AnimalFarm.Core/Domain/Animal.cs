using System;

namespace AnimalFarm.Core.Domain
{
    public abstract class Animal
    {
        private int _hungerLevel;
        
        public AnimalTypes Type { get; set; }
        public string Name { get; set; }
        public AnimalHungerStatus HungerStatus { get; set; }
        public string Identification
        {
            get { return $" {Type} - {Name} - {HungerStatus}"; }
        }
        public Animal(string name)
        {
            Name = name;
            _hungerLevel = 10;
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
        
        protected void Feed()
        {
            _hungerLevel = 10;
        }

        private void CalculateHungerStatus()
        {
            if (_hungerLevel == 10)
            {
                HungerStatus = AnimalHungerStatus.Full;
                return;
            }
            if (_hungerLevel >=8)
            {
                HungerStatus = AnimalHungerStatus.Satisfied;
                return;
            }
            if (_hungerLevel >= 6)
            {
                HungerStatus = AnimalHungerStatus.Snackish;
                return;
            }
            if (_hungerLevel >= 3)
            {
                HungerStatus = AnimalHungerStatus.Hungry;
                return;
            }

            HungerStatus = AnimalHungerStatus.Starving;
        }
        
        protected virtual void Run()
        {
            _hungerLevel -= 5;
        }
        
        //protected- access is limited
        protected virtual void Eat()
        {
            Feed();
        }
        
        private void Sleep()
        {
            _hungerLevel -= 2;
        }
        
        protected virtual void Fly()
        {
            if (Type != AnimalTypes.Eagle)
            {
                Console.WriteLine("Really?! Whatever");
                return;
            }
            Console.WriteLine("Animal is Flying");
            _hungerLevel -= 4;
        }
        
        protected virtual void Talk()
        {
            _hungerLevel -= 2;
        }
       
    }
}