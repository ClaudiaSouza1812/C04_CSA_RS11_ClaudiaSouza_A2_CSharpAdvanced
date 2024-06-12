using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_LINQ_linqMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            LinqMethods linqMethods = new LinqMethods();

            linqMethods.CitiesCustomersMethodSyntax();

            Utility.TerminateConsole();
        }
    }
}
