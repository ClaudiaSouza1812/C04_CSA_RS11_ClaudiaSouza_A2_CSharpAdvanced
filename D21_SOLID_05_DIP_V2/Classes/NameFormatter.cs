using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_SOLID_05_DIP_V1
{
    internal class NameFormatter : INameFormatter
    {
        public string FormatName(Person person)
        {
            return $"{person.FirstName} {person.LastName}";
        }

        public string FormatName(Employee employee)
        {
            return $"{employee.FirstName} {employee.LastName}";
        }
    }
}
