﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_SOLID_05_DIP.Classes
{
    internal class PersonRepository : IPersonRepository
    {
        private readonly List<Person> _people = new List<Person>();

        public void AddPerson(Person person)
        {
            _people.Add(person);
        }

        public Person GetPerson(string firstName, string lastName)
        {
            return _people.FirstOrDefault(p => p.FirstName == firstName && p.LastName == lastName);
        }
    }
}
