using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace E04_ExtensionMethod
{
    internal static class PersonExtensions
    {
        internal static string ListPersonName(this Person person)
        {
            return person.Name;
        }
    }
}
