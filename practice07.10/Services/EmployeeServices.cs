using practice07._10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice07._10.Services
{
    internal class EmployeeServices
    {
      public Employee[] FilterEmployeeBySalary(decimal startSalary, decimal endSalary)
        {
            Employee[] employees = GetAll();
            Employee[] filteredEmployees = employees.Where(m => m.Salary == startSalary && m.Salary <  endSalary).ToArray();

            return filteredEmployees;
        }

        private Employee[] GetAll()
        {
            return new Employee[]
            {
                new Employee
                {
                    Id = 1,
                    Name = "Tunzale",
                    Surname = "Memmedova",
                    Age = 24,
                    Salary = 1000
                },
                   new Employee
                {
                    Id = 2,
                    Name = "Semed",
                    Surname = "Huseynov",
                    Age = 27,
                    Salary = 1500
                },
                   new Employee
                {
                    Id = 3,
                    Name = "Oruc",
                    Surname = "Mehrabov",
                    Age = 26,
                    Salary = 1300
                },
            };

        }
    }
}
