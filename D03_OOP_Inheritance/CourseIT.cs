/* BASE CLASS: COURSE
    Propriedades: 
        CourseId
        Name (tem de ser em maiúsculas)
        Area (tem de ser em maiúsculas)
        FullCourse (read-only - get)

    Métodos void:
        ReadCourse
        ListCourse

    DERIVED CLASS - COURSEIT:

    Acrescentar a propriedade Exam?

*/
using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_OOP_Inheritance
{
    internal class CourseIT : Course
    {
        #region Properties

        internal bool Exam { get; set; }

        // reescrever a propriedade herdada
        // há duas formas: new, override
        internal new string FullCourse => $"Course nº {CourseId}: {Area} - {Name}, exam? {Exam}"; // Get

        #endregion

        #region Constructors

        internal CourseIT() : base()
        { 
            Exam = true;
        }

        internal CourseIT(int courseId, string name, string area, bool exam) : base(courseId, name, area)
        {
            Exam = exam;
        }


        #endregion

        #region Methods

        internal new void ReadCourse()
        {
            base.ReadCourse();

            Utility.WriteMessage("Course exam (true|false)? ");

            Exam = Convert.ToBoolean(Console.ReadLine());
        }

        internal new void ListCourse()
        {

            Utility.WriteMessage(FullCourse, "\n\n");
        }
        #endregion
    }
}
