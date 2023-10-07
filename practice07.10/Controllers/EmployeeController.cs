using practice07._10.Models;
using practice07._10.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice07._10.Controllers
{
    internal class EmployeeController
    {
        private EmployeeServices _employeeService;
        public EmployeeController()
        {
            _employeeService= new EmployeeServices();
        }
        public void GetFilteredEmployees()
        {
            decimal start = 1000;
            decimal end = 2000;
          foreach (Employee employee in _employeeService.FilterEmployeeBySalary(start, end))
            {
                string result = $"{employee.Name}- {employee.Surname} - {employee.Salary} - {employee.Age}";
                Console.WriteLine(result);
            }
        }
    }
}
