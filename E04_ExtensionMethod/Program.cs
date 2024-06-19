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

            List<Person> personList = new List<Person>();

            Person.AddPerson(personList);

            Person person01 = new Person("Claudia Souza");
            person01.Age = "31";

            Utility.WriteTitle("1. Extension method - return the person name", "", "\n");
            Utility.WriteMessage(PersonExtensions.ListPersonName(person01));

            Utility.WriteTitle("2. Tuple - return of a tuple with person name and age", "\n", "\n");
            Utility.WriteMessage($"Nome: {PersonExtensions.ListPersonNameAndAge(person01).Item1}, Idade: {PersonExtensions.ListPersonNameAndAge(person01).Item2}");

            // 3. Discard - Usar o discard para desestruturar o tuple devolvido pelo método GetPersonInfo.
            var (name, _) = Person.GetPersonInformation();

            Utility.WriteTitle("3. Discard - Destructure a returned tuple");
            Utility.WriteMessage(name);





            Utility.TerminateConsole();
        }
    }
}
