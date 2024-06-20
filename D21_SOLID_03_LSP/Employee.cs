using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_SOLID_03_LSP
{
    internal class Employee : Person
    {
        public string EmployeeID { get; set; }

        public Employee(string firstName, string lastName, int age, string employeeId) : base(firstName, lastName, age)
        { 
            EmployeeID = employeeId;
        }
    }
}
