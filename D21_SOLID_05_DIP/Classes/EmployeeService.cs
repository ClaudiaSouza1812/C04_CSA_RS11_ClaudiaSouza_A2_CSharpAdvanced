using D21_SOLID_05_DIP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_SOLID_05_DIP.Classes
{
    internal class EmployeeService
    {
        #region Properties
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IEmployeeNameFormatter _employeeNameFormatter;
        #endregion

        #region Constructor
        public EmployeeService(IEmployeeRepository employeeRepository, IEmployeeNameFormatter employeeNameFormatter)
        {
            _employeeRepository = employeeRepository;
            _employeeNameFormatter = employeeNameFormatter;
        }
        #endregion

        #region Methods and Functions

        public void AddEmployee(Employee employee)
        {
            _employeeRepository.AddEmployee(employee);
        }

        public string GetEmployeeFormattedName(int employeeId)
        {
            var employee = _employeeRepository.GetEmployee(employeeId);

            return _employeeNameFormatter.FormatEmployeeName(employee);
        }
        #endregion

    }
}
