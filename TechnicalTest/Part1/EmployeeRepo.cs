using System;
using System.Collections.Generic;
using System.Linq;

namespace TechnicalTest.Part1
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private List<Employee> Employees { get; }

        public EmployeeRepo()
        {
            Employees = new List<Employee>();
        }

        private IEnumerable<Employee> GetEmployees()
        {
            return Employees?.OrderBy(x => x.EmployeeID);
        }

        public bool AddEmployee(Employee employee)
        {
            if (employee == null)
                return false;

            Employees.Add(employee);

            return true;
        }

        public bool AddEmployee(List<Employee> employees)
        {
            if (!employees.Any())
                return false;

            Employees.AddRange(employees);

            return true;
        }

        public Employee GetEmployee(int employeeId)
        {
            return Employees?.FirstOrDefault(x => x.EmployeeID == employeeId);
        }

        public Array GetOrderedEmployeeArray() => GetEmployees().ToArray();

    }
}
