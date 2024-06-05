using E02_LINQ_LinqToObjects.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_LINQ_LinqToObjects.Interfaces
{
    internal interface ICustomer
    {
        #region Properties

        string Name { get; }
        City Location { get; }  // Simular relação de dependencia entre esta classe e a classe City (1-n)
        int Age { get; }

        #endregion
    }
}
