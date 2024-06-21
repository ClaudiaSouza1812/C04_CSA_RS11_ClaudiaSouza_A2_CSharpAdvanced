/*
    SOLID
    DIP
    Dependency Inversion Principle (DIP)
    As classes devem depender de abstrações, não de classes concretas
    Exemplo: criar a classe PersonService que depende de interfaces para realizar operações
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_SOLID_05_DIP_V1
{
    // Class to manage the Person data
    internal class PersonService
    {
        #region Properties
        // Properties with interfaces data types to allow Dependency Injection
        // Dependency Injection: to inject the implementation of the interfaces
        // Now the properties can call its methods without knowing the implementation details
        private readonly IPersonRepository _personRepository;
        private readonly INameFormatter _nameFormatter;
        #endregion

        #region Constructor
        // Constructor to receive the interfaces implementations
        public PersonService(IPersonRepository personRepository, INameFormatter personNameFormatter)
        {
            _personRepository = personRepository;
            _nameFormatter = personNameFormatter;
        }
        #endregion

        #region Methods ans Functions
        // Methods and Functions to call the interfaces methods
        public void AddPerson(Person person)
        {
            _personRepository.AddPerson(person);
        }

        public string GetFormattedName(string firstName, string lastName)
        {
            var person = _personRepository.GetPerson(firstName, lastName);

            return _nameFormatter.FormatName(person);
        }
        #endregion


    }
}
