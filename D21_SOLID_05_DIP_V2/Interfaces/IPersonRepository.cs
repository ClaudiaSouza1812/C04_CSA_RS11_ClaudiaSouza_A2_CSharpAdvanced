using D21_SOLID_05_DIP_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_SOLID_05_DIP_V1
{
    // Define the interface that will be implemented by the PersonRepository class, which will be used to interact with the database
    internal interface IPersonRepository
    {
        // Define the methods that will be implemented by the PersonRepository class
        void AddPerson(Person person);

        Person GetPerson(string firstName, string lastName);
    }
}
