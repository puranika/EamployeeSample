using System;
using System.Collections.Generic;

namespace Hello
{
    public class HR : Employee
    {
        string skill;

        public string Skill
        {
            get
            {
                return skill;
                
            }
            set
            {
                skill = value;
            }
        }

        List<string> skills;
    }
}
