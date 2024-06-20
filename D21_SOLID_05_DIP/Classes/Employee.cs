using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_SOLID_05_DIP
{
    internal class Employee : Person
    {
        public int EmployeeID { get; }
        private int NextID { get; set; } = 1;

        public Employee(string firstName, string lastName, int age) : base(firstName, lastName, age)
        { 
            EmployeeID = NextID++;
        }
    }
}
