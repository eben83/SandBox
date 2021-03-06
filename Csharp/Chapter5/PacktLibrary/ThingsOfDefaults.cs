using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class ThingsOfDefaults
    {
        public int Population;
        public DateTime When;
        public string Name;
        public List<Person> People;

        public ThingsOfDefaults()
        {
            //setting the constructor to the default values.
            Population = default;
            When = default;
            Name = default;
            People = default;
        }
    }
}