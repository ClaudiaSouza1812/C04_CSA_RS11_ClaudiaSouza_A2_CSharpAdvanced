using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace D04_OOP_Polymorphism
{
    internal class CourseSoftSkills : Course
    {
        /*
        herdada da classe Course

        propriedade: subarea

        read and list
        */

        #region Properties

        internal string Subarea { get; set; }

        // reescrever a propriedade herdada
        // há duas formas: new, override
        internal new string FullCourse => $"Course nº {CourseId}: {Area}, {Subarea} : {Name}"; // Get

        #endregion

        #region Constructors

        internal CourseSoftSkills() : base()
        {
            Subarea = string.Empty;
        }

        internal CourseSoftSkills(int courseId, string area, string subarea, string name) : base(courseId, name, area)
        {
            Subarea = subarea;
        }


        #endregion

        #region Methods

        internal new void ReadCourse()
        {
            base.ReadCourse();

            Utility.WriteMessage("Subarea: ");

            Subarea = Console.ReadLine();
        }

        internal new void ListCourse()
        {
            Utility.WriteMessage(FullCourse, "\n\n");
        }
        #endregion
    }
}
