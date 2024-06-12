using D00_Utility;
using E02_LINQ_LinqToObjects.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_LINQ_LinqToObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            CityCustomer customers = new CityCustomer();

            customers.CitiesCustomersMethodSyntax();

            


            Utility.TerminateConsole();
        }
    }
}
