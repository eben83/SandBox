using System;
using System.Collections.Generic;

namespace AnimalFarm.Core.Domain
{
    public class Dog : Animal
    {
       
        public Dog(string name) : base(name)
        {
            Type = AnimalTypes.Dog;
        }
        
        protected override List<string> Run()
        {
            _actionFeedback.Clear();
            _actionFeedback.Add("Whoosh");
            _actionFeedback.Add($"Play time for a {Type}, {Type}'s love to run");
            _actionFeedback.Add("They are the happiest while running around");
            return _actionFeedback;
        }

        protected override List<string> Eat()
        {
            _actionFeedback.Clear();
            _actionFeedback.Add("Burp");
            _actionFeedback.Add($"Look at this {Type}, how fast?");
            _actionFeedback.Add("How fast do they eat?");
            Feed();
            return _actionFeedback;
        }

        protected override List<string> Talk()
        {
            _actionFeedback.Clear();
            _actionFeedback.Add("Hello");
            _actionFeedback.Add("Bark!!");
            _actionFeedback.Add("Bark!!");
            return _actionFeedback;
        }
    }
}