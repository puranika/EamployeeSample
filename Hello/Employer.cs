using System;
using System.Collections.Generic;

namespace Hello
{
    public class Employer
	{
        string employerName;

        List<Employee> employees = new List<Employee>();

        public Employer(string name)
        {
            employerName = name;
        }

        public void SetEmployerName(string name) {
            this.employerName = name;
        }

        public string GetEmployerName() {
            return employerName;
        }

        public List<Employee> getEmployees()
        {
            return employees;
        }

    }
}