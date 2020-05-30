using System;
using System.Collections.Generic;

namespace AnimalFarm.Core.Domain
{
    public class Eagle : Animal
    {
        public Eagle(string name) : base(name)
        {
            Type = AnimalTypes.Eagle;
        }
        
        protected override List<string> Run()
        {
            _actionFeedback.Clear();
            _actionFeedback.Add("Whoosh");
            _actionFeedback.Add($"Why? why would you think this");
            _actionFeedback.Add($"{Type} they don't need to run..");
            return _actionFeedback;
        }
        protected override List<string> Eat()
        {
            _actionFeedback.Clear();
            _actionFeedback.Add("Burp");
            _actionFeedback.Add($"If you have a weak tummy");
            _actionFeedback.Add("You better look away");
            Feed();
            return _actionFeedback;
        }
        protected override List<string> Fly()
        {
            _actionFeedback.Clear();
            _actionFeedback.Add("Is it a bird?");
            _actionFeedback.Add("Is it a Plane?");
            _actionFeedback.Add($"It's a {Type}");
            return _actionFeedback;
        }
        protected override List<string> Talk()
        {
            _actionFeedback.Clear();
            _actionFeedback.Add("Hello");
            _actionFeedback.Add("Scream!!");    
            _actionFeedback.Add("Scream");
            return _actionFeedback;
        }
    }
}