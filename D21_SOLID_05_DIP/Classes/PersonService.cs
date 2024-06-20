using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_SOLID_05_DIP
{
    internal class PersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IPersonNameFormatter _personNameFormatter;

        public PersonService(IPersonRepository personRepository, IPersonNameFormatter personNameFormatter)
        {
            _personRepository = personRepository;
            _personNameFormatter = personNameFormatter;
        }

        public void AddPerson(Person person)
        {
            _personRepository.AddPerson(person);
        }

        public string GetFormattedName(string firstName, string lastName)
        { 
            var person = _personRepository.GetPerson(firstName, lastName);

            return _personNameFormatter.FormatName(person);
        }
    }
}
