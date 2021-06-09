using System.Collections.Generic;
using System.Linq;

namespace TechnicalTest.Part1
{
    public class EmployeeRepo
    {
        private List<Employee> Employees { get; }

        public EmployeeRepo()
        {
            Employees = new List<Employee>();
        }

        public List<Employee> GetEmployees()
        {
            return Employees;
        }

        public bool AddEmployee(Employee employee)
        {
            if (employee == null || Employees.Any(x => x.EmployeeID == employee.EmployeeID))
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

    }
}
