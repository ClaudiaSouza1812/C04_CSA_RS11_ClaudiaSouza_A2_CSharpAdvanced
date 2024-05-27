using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06_OOP_Interfaces
{
    internal class CourseIT : Course, ICourseIT
    {
        #region Properties

        public bool Exam { get; set; }

        #endregion

    }
}
