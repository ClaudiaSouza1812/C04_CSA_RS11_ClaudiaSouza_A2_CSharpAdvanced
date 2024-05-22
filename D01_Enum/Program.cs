using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Enum
{
    internal class Program
    {
        static List<Person> listPersons = new List<Person>();

        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Person person01 = new Person();
            person01.Name = "Claudia";
            person01.MaritalStatus = Person.EnumMaritalStatus.Married;

            Person person02 = new Person("bb", Person.EnumMaritalStatus.Single);
            /*
            listPersons.Add(person01);
            listPersons.Add(person02);
            */
            
            Person.AddPerson(listPersons);


            Utility.TerminateConsole();
        }
    }
}
