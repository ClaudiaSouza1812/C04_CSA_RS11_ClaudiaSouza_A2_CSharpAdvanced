using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_SOLID_05_DIP_V1
{
    // Define the class that will be used to format names
    internal class NameFormatter : INameFormatter
    {
        #region Methods and Functions
        // Functions to format the names of a person and an employee
        public string FormatName(Person person)
        {
            return $"{person.FirstName} {person.LastName}";
        }

        public string FormatName(Employee employee)
        {
            return $"{employee.FirstName} {employee.LastName}";
        }
        #endregion

    }
}
