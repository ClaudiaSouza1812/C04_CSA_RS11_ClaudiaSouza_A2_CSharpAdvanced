using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// A extension method serves to add a new method to a class (data type) without modifying the class itself
namespace E04_ExtensionMethod
{
    // The name of the class must express that it is an extension method of the Person class (data type)
    internal static class PersonExtensions
    {
        // The method must be static and the first parameter must be preceded by the keyword 'this' followed by the class name (data type) to which the method will be added

        // 1. Extension Method - Criar um método de extensão para a classe Person que devolve o nome completo da pessoa.
        internal static string ListPersonFullName(this Person person)
        {
            string fullName = $"{person.FirstName} {person.LastName}";
            return fullName;
        }

        // 2. Tuple - Criar um método que devolve um tuple com o nome completo e a idade da pessoa.
        internal static (string, string, string) ListPersonFullNameAndAge(this Person person)
        {
            return (person.FirstName, person.LastName, person.Age);
        }


    }
}
