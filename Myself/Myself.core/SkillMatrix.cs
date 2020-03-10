using System;
using System.ComponentModel.DataAnnotations;

namespace Myself.core
{
    public class SkillMatrix
    {

        public int ID { get; set; }
        public string Skill { get; set; }
        public ProficiencyType Proficiency { get; set; }
        public InterestType Interest { get; set; }
    }
}
