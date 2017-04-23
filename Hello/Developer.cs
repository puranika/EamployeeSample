using System;
using System.Collections.Generic;

namespace Hello
{
    public class Developer : Employee
    {
        string language;

        public string Language
        {
            get
            {
                return language;
            }

            set
            {
                language = value;
            }
        }

        List<string> languages;
    }
}
