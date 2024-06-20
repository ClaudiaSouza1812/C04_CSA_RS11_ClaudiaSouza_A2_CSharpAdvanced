using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_SOLID_05_DIP
{
    internal interface INameFormatter
    {
        string FormatName(Person person);
    }
}
