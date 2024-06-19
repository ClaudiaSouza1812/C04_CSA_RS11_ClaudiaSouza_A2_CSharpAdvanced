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

            //Person.AddPerson(personList);

            Person person01 = new Person("Claudia", "Souza", "31", Person.EnumMaritalStatus.Married, Person.EnumEyeColor.Brown, Person.EnumHairColor.Brown);

            #region Extension Method

            // 1. Extension Method - Criar um método de extensão para a classe Person que devolve o nome completo da pessoa.

            Utility.WriteTitle("1. Extension method - return the person full name", "", "\n");
            Utility.WriteMessage(person01.ListPersonFullName
                ());

            #endregion

            #region Tuple

            // 2. Tuple - Criar um método que devolve um tuple com o nome completo e a idade da pessoa.

            Utility.WriteTitle("2. Tuple - return of a tuple with person name and age", "\n", "\n");
            Utility.WriteMessage($"Nome: {person01.ListPersonFullNameAndAge().Item1} {person01.ListPersonFullNameAndAge().Item2}, Idade: {person01.ListPersonFullNameAndAge().Item3}");

            #endregion

            #region Discard

            // 3. Discard - Usar o discard para desestruturar o tuple devolvido pelo método GetPersonInfo.

            Utility.WriteTitle("3. Discard - Destructure a returned tuple", "\n", "\n");

            var (name, _) = Person.GetPersonInformation();

            Utility.WriteMessage(name);

            #endregion

            #region Deconstruct

            // 4. Deconstruct - Implementar o método Deconstruct na classe Person para permitir a desestruturação de objetos Person.

            Utility.WriteTitle("4. Deconstruct - Object destructing", "\n", "\n");

            var person02 = new Person();
            person02.LastName = "Souza";
            person02.MaritalStatus = Person.EnumMaritalStatus.Married;
            person02.EyeColor = Person.EnumEyeColor.Brown;

            var (_, lastName, _, maritalStatus, eyeColor, _) = person02;

            Utility.WriteMessage($"Last Name: {lastName}, Marital Status: {maritalStatus}, Eye Color: {eyeColor}");

            #endregion


            Utility.TerminateConsole();
        }
    }
}
