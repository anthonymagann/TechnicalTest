using System.Collections.Generic;

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
    }
}
