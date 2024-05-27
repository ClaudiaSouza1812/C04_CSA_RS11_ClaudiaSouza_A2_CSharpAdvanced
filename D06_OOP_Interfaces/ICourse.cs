using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06_OOP_Interfaces
{
    internal interface ICourse
    {
        #region Properties (public or internal)

        int CourseId { get; }
        string Name { get; }
        int FullCourse {  get; }

        #endregion

        #region Methods

        void ReadCourse();
        void ListCourse(string level);
        void ListCourse(DateTime timestamp);

        #endregion
    }
}
