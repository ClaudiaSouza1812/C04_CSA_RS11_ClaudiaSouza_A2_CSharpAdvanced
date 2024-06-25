using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_SOLID_05_DIP_V1
{
    // Define the Employee class, which will be used to represent an employee and inherit from the Person class
    internal class Employee : Person
    {
        #region Properties
        // Define the properties for the Employee class
        public int EmployeeID { get; }
        private int NextID { get; set; } = 1;
        #endregion

        #region Constructor
        // Define the constructor for the Employee with its parameters and the inherited parameters from the Person class
        public Employee(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            EmployeeID = NextID++;
        }
        #endregion

    }
}
