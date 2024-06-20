using D21_SOLID_05_DIP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_SOLID_05_DIP.Classes
{
    internal class EmployeeNameFormatter : IEmployeeNameFormatter
    {
        public string FormatEmployeeName(Employee employee)
        {
            return $"{employee.FirstName} {employee.LastName}";
        }
    }
}
