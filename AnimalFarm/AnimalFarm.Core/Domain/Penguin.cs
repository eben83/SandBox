using System;
using System.Collections.Generic;

namespace AnimalFarm.Core.Domain
{
    public class Penguin : Animal
    {
        public Penguin(string name) : base(name)
        {
            Type = AnimalTypes.Penguin;
        }


        protected override List<string> Run()
        {
            _actionFeedback.Clear();
            _actionFeedback.Add("Whoosh");
            _actionFeedback.Add($"HAHAHAHAHAHAHAH");
            _actionFeedback.Add($"Do {Type}'s even have knees");
            return _actionFeedback;
        }

        protected override List<string> Eat()
        {
            _actionFeedback.Clear();
            _actionFeedback.Add("Burp");
            _actionFeedback.Add($"They are very quick to catch fish, ");
            _actionFeedback.Add($"{Type}'s are very at catching fish");
            return _actionFeedback;
        }

        protected override List<string> Fly()
        {
            _actionFeedback.Clear();
            _actionFeedback.Add("Flap");
            _actionFeedback.Add("Flap");
            base.Fly();
            Feed();
            return _actionFeedback;
        }

        protected override List<string> Talk()
        {
            _actionFeedback.Clear();
            _actionFeedback.Add("Hello");
            _actionFeedback.Add("Sneeze!!");
            _actionFeedback.Add("Sneeze!!");
            return _actionFeedback;
        }
    }
}