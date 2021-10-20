using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace AnimalFarm.Core.Domain
{
    public class Elephant : Animal
    {
        public Elephant(string name) : base(name)
        {
            Type = AnimalTypes.Elephant;
        }
        
        protected override List<string> Run()
        {
            UpdateHungerStatus(5);
            _actionFeedback.Clear();
            _actionFeedback.Add("Whoosh");
            _actionFeedback.Add($"You might think- because of their size, they are slow.");
            _actionFeedback.Add($"Guess again, {Type}'s are a lot quicker than you think.");
            return _actionFeedback;
        }
        protected override List<string> Eat()
        {
            UpdateHungerStatus(0);
            _actionFeedback.Clear();
            _actionFeedback.Add("Burp");
            _actionFeedback.Add($"This time, an {Type} can eat, they will devour ");
            _actionFeedback.Add("A whole tree by themselves");
            Feed();
            return _actionFeedback;
        }
        protected override List<string> Talk()
        {
            UpdateHungerStatus(2);
            _actionFeedback.Clear();
            _actionFeedback.Add("Hello");
            _actionFeedback.Add("Trumpet!!");    
            _actionFeedback.Add("Trumpet!!");
            return _actionFeedback;
        }
    }
}
