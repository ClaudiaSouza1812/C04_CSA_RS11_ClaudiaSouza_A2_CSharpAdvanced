using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_SOLID_05_DIP
{
    internal class PersonNameFormatter : IPersonNameFormatter
    {
        public string FormatName(Person person)
        {
            return $"{person.FirstName} {person.LastName}";
        }
    }
}
