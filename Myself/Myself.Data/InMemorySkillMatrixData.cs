using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using Myself.Core;

namespace Myself.Data
{
    public class InMemorySkillMatrixData : ISkillMatrixData
    {
        List<SkillMatrix> skills;

        public InMemorySkillMatrixData()
        {
            skills = new List<SkillMatrix>
           {
               new SkillMatrix {ID = 1, Skill = "HTML", Proficiency  = ProficiencyType.Intermediate, Interest = InterestType.Elated},
               new SkillMatrix {ID = 2, Skill = "CSS", Proficiency = ProficiencyType.Beginner, Interest = InterestType.Electrified},
               new SkillMatrix {ID = 3, Skill = "Bootstrap", Proficiency = ProficiencyType.Beginner, Interest = InterestType.Eager},
               new SkillMatrix {ID = 4, Skill = "C#", Proficiency = ProficiencyType.Beginner, Interest = InterestType.Electrified},
               new SkillMatrix {ID = 5, Skill = "ASP.NET Core", Proficiency = ProficiencyType.Beginner, Interest = InterestType.Ecstatic},
               new SkillMatrix {ID = 6, Skill = "HTML Forms", Proficiency = ProficiencyType.Beginner, Interest = InterestType.Eager},
           };
        }



        //IEnumerable<SkillMatrix> ISkillMatrixData.GetSkillMatricesBySkill(string skill)
        //{
        //    throw new NotImplementedException();
        //}

        //public SkillMatrix GetById(int id)
        //{
        //    return skills.Single(s => s.ID == id);
        //}


    }
}
