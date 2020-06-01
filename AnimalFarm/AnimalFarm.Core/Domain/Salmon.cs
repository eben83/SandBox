using System;
using System.Collections.Generic;

namespace AnimalFarm.Core.Domain
{
    public class Salmon : Animal
    {
        public Salmon(string name) : base(name)
        {
            Type = AnimalTypes.Salmon;
        }
        
        protected override List<string> Run()
        {
            UpdateHungerStatus(5);
            _actionFeedback.Clear();
            _actionFeedback.Add("Whoosh");
            _actionFeedback.Add($"Well, this type of run, Is not what you expect");
            _actionFeedback.Add($"Once a year there is something called a {Type} run");
            return _actionFeedback;
        }
        protected override List<string> Eat()
        {
            UpdateHungerStatus(0);
            _actionFeedback.Clear();
            _actionFeedback.Add("Burp");
            _actionFeedback.Add($"Do {Type} even eat");
            _actionFeedback.Add("This might be one of the seven wonders of the world");
            Feed();
            return _actionFeedback;
        }
        protected override List<string> Talk()
        {
            UpdateHungerStatus(2);
            _actionFeedback.Clear();
            _actionFeedback.Add("Hello");
            _actionFeedback.Add("Bubble!!");    
            _actionFeedback.Add("Bubble!!");
            return _actionFeedback;
        }
    }
}