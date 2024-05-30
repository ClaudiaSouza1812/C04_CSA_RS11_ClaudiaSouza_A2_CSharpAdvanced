using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

        /* reescrever a propriedade herdada: override
        ofuscar, criar uma nova propriedade com o mesmo nome: new, ex:
        internal new string FullCourse => $"Course nº {CourseId}: {Area}, {Subarea} : {Name}"; // Get
        override: polimorfismo, substituição do que é herdado, ex:
        internal override string FullCourse => $"Course nº {CourseId}: {Area}, {Subarea} : {Name}"; // Get
        */

        internal override string FullCourse => $"Course nº {CourseId}: {Area}, {Subarea} : {Name}"; // Get
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

        internal override void ReadCourse()
        {
            base.ReadCourse();

            Utility.WriteMessage("Subarea: ");

            Subarea = Console.ReadLine();
        }

        // Polimorphism with Overloading method
        internal void ListCourse(string level)
        {
            Utility.WriteMessage($"{FullCourse} ({level}), ", "\n\n");
        }

        internal void ListCourse(DateTime timestamp)
        {
            Utility.WriteMessage($"{FullCourse} ({timestamp.ToShortDateString()}), ", "\n\n");
        }


        #endregion
    }
}
