﻿using System;
using System.Collections.Generic;

namespace Hello
{
    public class Employee
    {
        string firstName;
        string lastName;


        public string FirstName
        {
            get 
            { return firstName; 
            }
            set {
                firstName = value;
            }
        }

		public string LastName
		{
			get
			{
                return lastName;
			}
			set
			{
                lastName = value;
			}
		}
    }
}
