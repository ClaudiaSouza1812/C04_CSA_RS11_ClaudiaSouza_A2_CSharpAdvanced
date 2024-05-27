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

namespace D05_OOP_Abstraction
{
    internal class CourseIT : Course
    {
        #region Properties

        internal bool Exam { get; set; }

        // reescrever a propriedade herdada: override
        // ofuscar, criar uma nova com o mesmo nome: new 
        internal override string FullCourse => $"Course nº {CourseId}: {Area} - {Name}, Exam? {Exam}"; // Get

        internal override double Price { get; set; }

        #endregion

        #region Constructors

        internal CourseIT() : base()
        { 
            Exam = true;
            Price = 100.00;
        }

        internal CourseIT(int courseId, string name, string area, bool exam) : base(courseId, name, area)
        {
            Exam = exam;
            Price = 100.00; ;
        }


        #endregion

        #region Methods

        internal override void ReadCourse()
        {
            base.ReadCourse();

            Utility.WriteMessage("Course exam (true|false)? ");

            Exam = Convert.ToBoolean(Console.ReadLine());
        }

        internal override void ListCourse()
        {

            Utility.WriteMessage(FullCourse, "\n\n");
        }

        internal override void Billing(string status)
        {
            Utility.WriteMessage($"({Price:C2}) Estado de pagamento: {status}", "\n", "\n\n");
        }





        #endregion
    }
}
