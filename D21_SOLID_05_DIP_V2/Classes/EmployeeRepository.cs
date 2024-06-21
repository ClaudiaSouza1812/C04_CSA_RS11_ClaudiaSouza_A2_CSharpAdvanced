using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_SOLID_05_DIP_V1.Classes
{
    // Define the class that will be used to interact with the database
    internal class EmployeeRepository : IEmployeeRepository
    {
        #region Fields
        // Define the list of employees
        private readonly List<Employee> _employees = new List<Employee>();
        #endregion

        #region Methods ans Functions
        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public Employee GetEmployee(int employeeId)
        {
            return _employees.FirstOrDefault(e => e.EmployeeID == employeeId);
        }
        #endregion

    }
}
