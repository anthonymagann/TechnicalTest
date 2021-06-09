using System;
using System.Collections.Generic;
using TechnicalTest.Part1;

namespace TechnicalTest
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Tech Test!");

            //Part 1
            IEmployeeRepo staff = new EmployeeRepo();

            staff.AddEmployee(
                new List<Employee> { new Employee(2, "Sinead", "Magann"),
                  new Employee(1, "Anthony", "Magann")
                });


            var employee = staff.GetEmployee(1);
            var Employees = staff.GetOrderedEmployeeArray();



        }
    }
}
