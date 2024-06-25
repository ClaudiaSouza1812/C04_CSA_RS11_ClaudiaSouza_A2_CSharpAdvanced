using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_SOLID_05_DIP_V1
{
    // Defines the Person class, which will be used to store information about a person, and will allow other objects of the same type to inherit it
    internal class Person
    {
        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        #endregion

        #region Constructor
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        #endregion

    }
}
