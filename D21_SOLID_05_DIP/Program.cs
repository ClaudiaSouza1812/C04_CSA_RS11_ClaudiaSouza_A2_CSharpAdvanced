using D00_Utility;
using D21_SOLID_05_DIP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_SOLID_05_DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            // Repositories
            IPersonRepository personRepository = new PersonRepository();
            INameFormatter nameFormatter = new FullNameFormatter();
            PersonService personService = new PersonService(personRepository, nameFormatter);

            // Add person
            Person person = new Person("Milena", "Reis e Sousa", 56);
            personService.AddPerson(person);

            // Get person formatted name

            string formattedName = personService.GetFormattedName("Milena", "Reis e Sousa");
            Utility.WriteMessage($"Formatted name: {formattedName}");



            Utility.TerminateConsole();
        }
    }
}
