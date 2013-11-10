using System;
using System.Collections.Generic;
using System.Linq;


namespace CSC325_Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramUtilities pu = new ProgramUtilities();
            
            List<Employee> regularEmployees = new List<Employee>(10);
            List<Employee> bonusEmployees = new List<Employee>(10);

            pu.PopulateCommonEmployees(regularEmployees);
            pu.PopulateRandomEmployees(regularEmployees);

            pu.PopulateCommonEmployees(bonusEmployees);
            pu.PopulateRandomEmployees(bonusEmployees);


            // queryA ////////////////////////////////////
            var queryA =
                from e in regularEmployees
                select e;
            Console.WriteLine("QueryA\n");
            foreach (var e in queryA)
                Console.WriteLine(e);


            // queryB ////////////////////////////////////
            var queryB =
                from e in regularEmployees
                orderby e.EmployeeID
                select e;
            Console.WriteLine("\nQueryB\n");
            foreach (var e in queryB)
                Console.WriteLine(e);


            // queryC ////////////////////////////////////
            var queryC =
                from e in regularEmployees
                orderby e.Salary descending, e.Name
                select e;
            Console.WriteLine("\nQueryC\n");
            foreach (var e in queryC)
                Console.WriteLine(e);


            // queryD ////////////////////////////////////
            var queryD =
                from e in regularEmployees
                where e.Level == Employee.Levels.Administrator || e.Level == Employee.Levels.Staff
                select e;
            Console.WriteLine("\nQueryD\n");
            foreach (var e in queryD)
                Console.WriteLine(e);


            // queryE ////////////////////////////////////
            var queryE =
                from e in regularEmployees
                select new { e.Name, e.Level };
            Console.WriteLine("\nQueryE\n");
            foreach (var e in queryE)
                Console.WriteLine(e);


            // queryBonus ////////////////////////////////
            var queryBonus =
                from re in regularEmployees
                join be in bonusEmployees
                    on re.EmployeeID equals be.EmployeeID
                select re;
            Console.WriteLine("\nQueryBonus\n");
            foreach(var e in queryBonus)
                Console.WriteLine(e);
        }
    }
}

