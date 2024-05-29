using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06_OOP_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region Course IT

            CourseIT courseIt01 = new CourseIT();

            Utility.WriteTitle("Course IT", "", "\n\n");

            courseIt01.ReadCourse();

            courseIt01.ListCourse();

            courseIt01.ListCourse("Level 2");

            courseIt01.Billing("Pago");

            #endregion

            #region Course Soft Skills

            CourseSoftSkills courseSoftSkills01 = new CourseSoftSkills();

            courseSoftSkills01.ReadCourse();

            courseSoftSkills01.ListCourse();

            courseSoftSkills01.ListCourse("Level 1");

            courseSoftSkills01.ListCourse(DateTime.Today);

            courseSoftSkills01.Billing("Pago");

            #endregion


            Utility.TerminateConsole();
        }
    }
}
