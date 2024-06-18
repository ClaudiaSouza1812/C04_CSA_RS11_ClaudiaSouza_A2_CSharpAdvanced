using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04_ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Person person01 = new Person("Claudia");

            Utility.WriteMessage(person01.ListPersonName());


            Utility.TerminateConsole();
        }
    }
}
