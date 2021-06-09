using System;
using System.Collections.Generic;
using TechnicalTest.Part1;
using TechnicalTest.Part2;
using TechnicalTest.Part3;

namespace TechnicalTest
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Tech Test!");

            //Part 1
            IEmployeeRepo staff = new EmployeeRepo();

            staff.AddEmployee(
                new List<Employee> { new Employee(2, "Sinead", "Magann"),
                  new Employee(1, "Anthony", "Magann")
                });

            var employee = staff.GetEmployee(1);
            var employees = staff.GetOrderedEmployeeArray();

            //Part 2
            var VehicleType = "truck";
            VehicleWork.VehicleWorkResolve(VehicleType);

            //Part 3
            var products = new List<Product>
            {
                new Product {Id = new Guid(), Price = 34.00m},
                new Product {Id = new Guid(), Price = 1.00m}
            };

            ILocalizationInfo localInfo = new LocalizationInfo();
            ICartTotal cart = new CartTotal();
            var total = cart.Calculate(products, localInfo);
            Console.WriteLine("Total {0}", total);
        }
    }
}