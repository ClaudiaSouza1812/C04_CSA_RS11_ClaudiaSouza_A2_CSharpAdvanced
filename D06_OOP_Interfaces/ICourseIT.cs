using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06_OOP_Interfaces
{
    internal interface ICourseIT : ICourse
    {
        #region Properties

        bool Exam { get; }

        #endregion
    }
}
