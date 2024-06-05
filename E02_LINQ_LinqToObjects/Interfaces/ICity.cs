using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_LINQ_LinqToObjects.Interfaces
{
    internal interface ICity
    {
        #region Properties

        string Location { get; }
        string Country { get; }

        #endregion

    }
}
