using D21_SOLID_01_SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_SOLID_02_OCP
{
    internal interface INameFormatter
    {
        string FormatName(Person person);
    }
}
