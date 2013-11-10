using System;


namespace CSC325_Assignment03
{

    

    class Employee
    {
        public enum Levels { Administrator = 'a', Staff = 's', Instructor = 'i' };

        public string Name { get; private set; }
        public string EmployeeID { get; private set; }
        public double Salary { get; private set; } 
        public Levels Level { get; private set; }

        public Employee(string Name, string EmployeeID, double Salary, char Level)
        {
            this.Name = Name;
            this.EmployeeID = EmployeeID;
            this.Salary = Salary;
            this.Level = (Levels)Level;
        }

        public override string ToString()
        {
            return (String.Format("Name: {0,20}\tEmployee ID: {1,10} \nLevel: {2,20}\tSalary: {3,15}", Name, EmployeeID, Level, Salary));
        }
    }
}
