using System;
using System.Collections.Generic;

namespace AnimalFarm.Core.Domain
{
    public abstract class Animal
    {
        private int _hungerLevel;
        protected readonly List<string> _actionFeedback = new List<string>();
        
        public AnimalTypes Type { get; set; }
        public string Name { get; set; }
        public AnimalHungerStatus HungerStatus { get; set; }
        public string Identification
        {
            get { return $" {Type} - {Name} - {(int)_hungerLevel} - {HungerStatus}"; }
        }
        public Animal(string name)
        {
            Name = name;
            _hungerLevel = 10;
        }
        
        public List<string> Command(AnimalActions animalAction)
        {
            switch(animalAction)
            {
                case AnimalActions.Run:
                    return Run();
                case AnimalActions.Eat:
                    return Eat();
                case AnimalActions.Sleep:
                    return Sleep();
                case AnimalActions.Fly:
                    return Fly();
                case AnimalActions.Talk:
                    return Talk();
                default:
                    throw new ArgumentOutOfRangeException(nameof(animalAction), "Use the enum directly"); 
            }
        }
        
        protected void Feed()
        {
            UpdateHungerStatus(0);
        }

        protected void UpdateHungerStatus(int effort)
        {
            if (effort == 0)
                _hungerLevel = 12;
            else
                _hungerLevel -= effort;

            
            if (_hungerLevel == 12)
            {
                HungerStatus = AnimalHungerStatus.Full;
                return;
            }
            if (_hungerLevel >=9)
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
        
        protected virtual List<string> Run()
        {
            UpdateHungerStatus(5);
            return _actionFeedback;
        }
        
        //protected- access is limited
        protected virtual List<string> Eat()
        {
            Feed();
            return _actionFeedback;
        }
        
        private List<string> Sleep()
        {
            UpdateHungerStatus(2);
            return _actionFeedback;
        }
        
        protected virtual List<string> Fly()
        {
            _actionFeedback.Clear();
            
            if (Type != AnimalTypes.Eagle)
            {
                _actionFeedback.Add("Really?! Whatever");
            }
            
            _actionFeedback.Add("Animal is Flying");
            UpdateHungerStatus(4);
            return _actionFeedback;
        }
        
        protected virtual List<string> Talk()
        {
            UpdateHungerStatus(2);
            return _actionFeedback;
        }
       
    }
}