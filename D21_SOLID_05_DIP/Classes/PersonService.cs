﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_SOLID_05_DIP
{
    internal class PersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly INameFormatter _nameFormatter;

        public PersonService(IPersonRepository personRepository, INameFormatter nameFormatter)
        {
            _personRepository = personRepository;
            _nameFormatter = nameFormatter;
        }

        public void AddPerson(Person person)
        {
            _personRepository.AddPerson(person);
        }

        public string GetFormattedName(string firstName, string lastName)
        { 
            var person = _personRepository.GetPerson(firstName, lastName);
            return _nameFormatter.FormatName(person);
        }
    }
}
