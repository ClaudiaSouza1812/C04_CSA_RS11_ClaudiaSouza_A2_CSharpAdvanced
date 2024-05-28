using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06_OOP_Interfaces
{
    // Herda propriedades e métodos da interface ICourseIT e da classe Course
    // Herdar da classe Course é o mesmo que herdar da interface ICourse

    internal class CourseIT : Course, ICourseIT
    {
        // implanta as propriedades que pertencem unicamente a ICourseIT

        #region Properties

        public bool Exam { get; set; }

        #endregion

    }
}
