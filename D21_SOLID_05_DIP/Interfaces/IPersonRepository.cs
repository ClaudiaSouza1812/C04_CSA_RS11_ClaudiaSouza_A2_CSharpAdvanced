using D21_SOLID_05_DIP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_SOLID_05_DIP
{
    internal interface IPersonRepository
    {
        void AddPerson(Person person);

        Person GetPerson(string firstName, string lastName);
    }
}
