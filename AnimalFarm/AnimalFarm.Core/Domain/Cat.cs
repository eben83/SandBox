using System;
using System.Collections.Generic;

namespace AnimalFarm.Core.Domain
{
    public class Cat : Animal
    {

        public Cat(string name) : base(name)
        {
            Type = AnimalTypes.Cat;
        }
        
        protected override List<string> Run()
        {
            _actionFeedback.Clear();
            _actionFeedback.Add("Whoosh");
            _actionFeedback.Add($"Running, They will rather watch");
            _actionFeedback.Add("You Run around");
            return _actionFeedback;
        }
        protected override List<string> Eat()
        {
            _actionFeedback.Clear();
            _actionFeedback.Add("Burp");
            _actionFeedback.Add($"I think you never feed your own {Type}");
            _actionFeedback.Add($"You probably feed everyone else's {Type}'s ");
            Feed();
            return _actionFeedback;
        }
        protected override List<string> Talk()
        {
            _actionFeedback.Clear();
            _actionFeedback.Add("Meow!!");    
            _actionFeedback.Add("Hello");
            _actionFeedback.Add("Meow!!");
            return _actionFeedback;
        }
    }
}
