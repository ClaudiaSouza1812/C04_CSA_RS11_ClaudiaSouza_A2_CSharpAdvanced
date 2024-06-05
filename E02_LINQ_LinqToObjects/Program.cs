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

            customers.CreateCitiesCustomers();

            customers.MethodSyntaxQuestion1();

            customers.MethodSyntaxQuestion2();

            customers.MethodSyntaxQuestion3();


            Utility.TerminateConsole();
        }
    }
}
