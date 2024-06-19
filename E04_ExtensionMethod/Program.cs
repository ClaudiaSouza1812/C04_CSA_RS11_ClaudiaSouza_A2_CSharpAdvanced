using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E04_ExtensionMethod;

namespace E04_ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            List<Person> personList = new List<Person>();

            Person.AddPerson(personList);

            Person person01 = new Person("Claudia", Person.EnumMaritalStatus.Married);
            person01.Age = "31";

            // 1. Extension Method - Criar um método de extensão para a classe Person que devolve o nome completo da pessoa.

            Utility.WriteTitle("1. Extension method - return the person full name", "", "\n");
            Utility.WriteMessage(PersonExtensions.ListPersonFullName(person01).Item1, PersonExtensions.ListPersonFullName(person01).Item2);

            // 2. Tuple - Criar um método que devolve um tuple com o nome completo e a idade da pessoa.

            Utility.WriteTitle("2. Tuple - return of a tuple with person name and age", "\n", "\n");
            Utility.WriteMessage($"Nome: {PersonExtensions.ListPersonFullNameAndAge(person01).Item1} {PersonExtensions.ListPersonFullNameAndAge(person01).Item2}, Idade: {PersonExtensions.ListPersonFullNameAndAge(person01).Item3}");

            // 3. Discard - Usar o discard para desestruturar o tuple devolvido pelo método GetPersonInfo.
            
            Utility.WriteTitle("3. Discard - Destructure a returned tuple");

            var (name, _) = Person.GetPersonInformation();

            Utility.WriteMessage(name);

            // 4. Deconstruct - Implementar o método Deconstruct na classe Person para permitir a desestruturação de objetos Person.

            Utility.WriteTitle("4. Deconstruct - Object destructing");

            var person02 = new Person();

            var (lastName, maritalStatus, eyeColor) = person02;


            Utility.TerminateConsole();
        }
    }
}
