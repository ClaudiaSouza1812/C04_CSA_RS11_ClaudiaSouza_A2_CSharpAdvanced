using D21_SOLID_04_ISP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_SOLID_04_ISP
{
    internal interface IPersonRepository
    {
        void AddPerson(Person person);

        Person GetPerson(string firstName, string lastName);
    }
}
