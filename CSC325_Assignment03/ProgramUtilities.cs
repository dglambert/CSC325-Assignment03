using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC325_Assignment03
{
    class ProgramUtilities
    {
        Random rand = new Random();
        public void PopulateCommonEmployees(List<Employee> employees)
        {
            employees.Add(new Employee("Devin Gleason Lambert", "e0000001", 20.00, 'a'));
            employees.Add(new Employee("Mikhail Brikman", "e0000002", 40.00, 's'));
            employees.Add(new Employee("Beth Van Belle", "e0000003", 60.00, 'i'));
            employees.Add(new Employee("Albert Beltran", "e0000004", 80.00, 's'));
            employees.Add(new Employee("Mike Hedel", "e0000005", 100.00, 'i'));
        }

        public void PopulateRandomEmployees(List<Employee> employees)
        {
           for(int i=0; i<5; i++)
               employees.Add(EmployeeGenerator());
        }

        public Employee EmployeeGenerator()
        {
            return new Employee(NameGenerator(), EmployeeIDGenerator(), SalaryGenerator(), LevelGenerator());
        }
        
        public char LevelGenerator()
        {
            switch (rand.Next(0, 3))
            {
                case 0:
                    return 'a';
                case 1:
                    return 'i';
                default:
                    return 's';
            }
        }

        public string NameGenerator()
        {
            string[] firsts = new[] { "devin", "beth", "albert", "mikhail", "frank", "mike", "steve", "joe", "beifang", "bo" };
            string[] lasts = new[] { "gleason-lambert", "van belle", "beltran", "brikman", "dalton", "hedel", "cutler", "kasprzyk", "yi", "hatfield" };

            return firsts[rand.Next(firsts.Length - 1)] + " " + lasts[rand.Next(lasts.Length - 1)];
        }

        public double SalaryGenerator()
        {
            return Math.Round(rand.NextDouble() * 100000, 2);
        }

        public string EmployeeIDGenerator()
        {
            return ("e" + rand.Next(1000000, 9999999).ToString());
        }
    }
}
