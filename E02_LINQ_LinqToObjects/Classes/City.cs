using E02_LINQ_LinqToObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_LINQ_LinqToObjects.Classes
{
    internal class City : ICity
    {
        public string Location { get; set; }

        public string Country { get; set; }
    }
}
