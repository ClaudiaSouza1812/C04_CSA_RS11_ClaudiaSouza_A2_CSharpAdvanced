using D21_SOLID_05_DIP_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_SOLID_05_DIP_V1.Classes
{
    // Class that will be used to manage employees
    internal class EmployeeService
    {
        #region Properties
        // Properties with interfaces data types to implement the Dependency Inversion Principle
        private readonly IEmployeeRepository _employeeRepository;
        private readonly INameFormatter _nameFormatter;
        #endregion

        #region Constructor
        // Constructor to receive the interfaces implementations
        public EmployeeService(IEmployeeRepository employeeRepository, INameFormatter employeeNameFormatter)
        {
            _employeeRepository = employeeRepository;
            _nameFormatter = employeeNameFormatter;
        }
        #endregion

        #region Methods and Functions
        // Methods and Functions to call the interfaces methods
        public void AddEmployee(Employee employee)
        {
            _employeeRepository.AddEmployee(employee);
        }

        public string GetEmployeeFormattedName(int employeeId)
        {
            var employee = _employeeRepository.GetEmployee(employeeId);

            return _nameFormatter.FormatName(employee);
        }
        #endregion

    }
}
