using HRAdministratonAPI; // Adding Reference of HRAdministrationAPI
using System;
using System.Collections.Generic;

using System.Linq;

namespace SchoolHRadministraton
{
    public enum EmployeeType
    {
        Teacher, 
        HeadOfDept,
        DeputyHeadMaster,
        HeadMaster
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            decimal totalSalaries = 0; 
            List<IEmployee> employees = new List<IEmployee>();

            SeedData(employees);

            // foreach (IEmployee employee in employees)
            // {
            //     totalSalaries += employee.Salary;
            // }
            // Console.WriteLine($"Total Annual Salaries (including Bonus) : {totalSalaries}");
            
            Console.WriteLine($"Total Annual Salaries (including Bonus) : {employees.Sum(e => e.Salary)}"); // instaed of the above foreach loop, we can use this "Sum" method!
            Console.ReadKey();
        }

        public static void SeedData(List<IEmployee> employees)
        {
            // IEmployee teacher1 = new Teacher
            // {
            //     Id = 1,
            //     FName = "Jenny",
            //     LName = "Thomas",
            //     Salary = 50000
            // };
            IEmployee teacher1 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 1, "Jenny", "Thomas", 50000);
            employees.Add(teacher1);
            // IEmployee teacher2 = new Teacher
            // {
            //     Id = 2,
            //     FName = "Lucy",
            //     LName = "Finsher",
            //     Salary = 60000
            // };
            IEmployee teacher2 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 2, "Lucy", "Finsher", 60000);
            employees.Add(teacher2);
            // IEmployee teacher3 = new Teacher
            // {
            //     Id = 3,
            //     FName = "Vilsa",
            //     LName = "Ruther",
            //     Salary = 40000
            // };
            IEmployee teacher3 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 3, "Vilsa", "Ruther", 40000);
            employees.Add(teacher3);
            // IEmployee teacher4 = new Teacher
            // {
            //     Id = 4,
            //     FName = "Saira",
            //     LName = "Begam",
            //     Salary = 37000
            // };
            IEmployee teacher4 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 4, "Saira", "Begum", 37000);
            employees.Add(teacher4);
            // IEmployee teacher5 = new Teacher
            // {
            //     Id = 5,
            //     FName = "Vincy",
            //     LName = "Robert",
            //     Salary = 70000
            // };
            IEmployee teacher5 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 5, "Vincy", "Robert", 70000); 
            employees.Add(teacher5);

            // IEmployee headofDept = new HeadOfDept
            // {
            //     Id = 6,
            //     FName = "Brenda",
            //     LName = "Mullins",
            //     Salary = 150000
            // };
            IEmployee headofDept = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadOfDept, 6, "Brenda", "Mullins", 150000); 
            employees.Add(headofDept);

            // IEmployee deputyHeadMaster = new DeputyHeadMaster
            // {
            //     Id = 7,
            //     FName = "Ferinda",
            //     LName = "Roslin",
            //     Salary = 70000
            // };
            IEmployee deputyHeadMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.DeputyHeadMaster, 7, "Ferinda", "Roslin", 70000); 
            employees.Add(deputyHeadMaster);;

            // IEmployee headMaster = new HeadMaster
            // {
            //     Id = 8,
            //     FName = "Varsha",
            //     LName = "Gnanam",
            //     Salary = 170000
            // };
            IEmployee headMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadMaster, 8, "Varsha", "Gnanam", 170000); 
            employees.Add(headMaster);        
        }
    }

    public class Teacher : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.02m); }
    }

    public class HeadOfDept : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.03m); }
    }

    public class DeputyHeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.04m); }
    }

    public class HeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.05m); }
    }

    public static class EmployeeFactory
    {
        public static IEmployee GetEmployeeInstance(EmployeeType employeeType, int id, string firstName, string lastName, decimal Salary)
        {
            IEmployee employee = null;
            switch(employeeType)
            {
                case EmployeeType.Teacher:
                    employee = new Teacher{Id = id, FName = firstName, LName = lastName, Salary = Salary};
                    break;
                case EmployeeType.HeadOfDept:
                    employee = new HeadOfDept{Id = id, FName = firstName, LName = lastName, Salary = Salary};
                    break;
                case EmployeeType.DeputyHeadMaster:
                    employee = new DeputyHeadMaster{Id = id, FName = firstName, LName = lastName, Salary = Salary};
                    break;
                case EmployeeType.HeadMaster:
                    employee = new HeadMaster{Id = id, FName = firstName, LName = lastName, Salary = Salary};
                    break;
                default:
                    break;
            }
            return employee;
        }
    }
}
