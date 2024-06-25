using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_SOLID_05_DIP_V1.Classes
{
    // Define the class that will be used to interact with the database
    internal class PersonRepository : IPersonRepository
    {
        #region Fields
        // Define the list of people
        private readonly List<Person> _people = new List<Person>();
        #endregion

        #region Methods and Functions
        // Define the methods to add a person and get a person
        public void AddPerson(Person person)
        {
            _people.Add(person);
        }

        public Person GetPerson(string firstName, string lastName)
        {
            return _people.FirstOrDefault(p => p.FirstName == firstName && p.LastName == lastName);
        }
        #endregion

    }
}
