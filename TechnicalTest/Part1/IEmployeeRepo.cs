﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalTest.Part1
{
    public interface IEmployeeRepo
    {
        bool AddEmployee(Employee employee);
        bool AddEmployee(List<Employee> employees);
        Employee GetEmployee(int employeeId);
        Array GetOrderedEmployeeArray();
    }
}
