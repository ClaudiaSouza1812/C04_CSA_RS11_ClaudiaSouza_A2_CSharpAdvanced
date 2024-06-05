using E02_LINQ_LinqToObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_LINQ_LinqToObjects.Classes
{
    internal class Customer : ICustomer
    {
        public string Name { get; set; }

        public City Location { get; set; }  // Dependency relationship with the class City 

        public int Age { get; set; }
    }
}
