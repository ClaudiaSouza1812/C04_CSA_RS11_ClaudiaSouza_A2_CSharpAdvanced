
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_SOLID_05_DIP_V1
{
    // Define the interface that will be implemented by the NameFormatter class, which will be used to format names
    internal interface INameFormatter
    {
        // Define the methods that will be implemented by the NameFormatter class
        string FormatName(Person person);

        string FormatName(Employee employee);
    }
}
