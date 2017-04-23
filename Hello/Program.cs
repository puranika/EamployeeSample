using System;
using System.Collections.Generic;

namespace Hello
{
	class MainClass
	{
		public static void Main(string[] args)
		{
            List<Employer> employers = new List<Employer>();

            // define apple employer along with its employees
            Employer apple = new Employer("Apple Inc");
            //apple.SetEmployerName("Apple Inc");

            Employee abhi = new Employee();
            abhi.FirstName = "Abhi";
            abhi.LastName = "Puranik";

            apple.getEmployees().Add(abhi);

            // add to employers
            employers.Add(apple);

            Console.WriteLine("Please enter employer name");
            Employer employer = new Employer(Console.ReadLine());
            //employer.SetEmployerName(Console.ReadLine());

            Console.WriteLine("Please enter employee information for two employees");
            int index = 0;
            while (index < 2) {
				Employee employee = new Employee();
                Console.WriteLine("Please enter employer firstname for employee no. {0}", index);
				employee.FirstName = Console.ReadLine();

                Console.WriteLine("Please enter employer lastnamefor employee no. {0}", index);
				employee.LastName = Console.ReadLine();

                employer.getEmployees().Add(employee);
                index++;
                Console.WriteLine();
            }

            // add to employer
            employers.Add(employer);

            // display
            Console.WriteLine("");
            Console.WriteLine("");
            DisplayEmployers(employers);


            DisplayEmployers(employers);

            Console.ReadLine();

            foreach (Employer empl in employers)
            {
                if (empl.GetEmployerName() == "google")
                {
                    Employee employee = new Employee();
                    employee.FirstName = "HI";
                    employee.LastName = "Bye";

                    empl.getEmployees().Add(employee);
                }
            }

            DisplayEmployers(employers);




        }


        public static void DisplayEmployers(List<Employer> employers) {

            int index = 1;
            foreach(Employer employer in employers) {
                Console.WriteLine();
                Console.WriteLine("Employer no. {0}", index);
                Console.WriteLine("Employer name: {0}", employer.GetEmployerName());
                Console.WriteLine("Employees for {0} are: ", employer.GetEmployerName());

                int employeeIndex = 1;
                foreach(Employee employee in employer.getEmployees()) {
                    Console.WriteLine("Employee {0}: {1} {2}", employeeIndex, employee.FirstName, employee.LastName);
                    employeeIndex++;
                }
                index++;
            }
            
        }
	}
}
