using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region Course

            Course course01 = new Course();

            Utility.WriteTitle("Course", "", "\n\n");

            course01.ReadCourse();

            course01.ListCourse();

            #endregion

            #region CourseIT

            CourseIT courseit01 = new CourseIT();

            Utility.WriteTitle("Course IT", "", "\n\n");

            courseit01.ReadCourse();

            courseit01.ListCourse();

            #endregion

            #region CourseSoftSkills

            CourseSoftSkills coursesoft01 = new CourseSoftSkills();

            coursesoft01.ReadCourse();

            coursesoft01.ListCourse("Level 1");

            coursesoft01.ListCourse(DateTime.Today);

            #endregion


            Utility.TerminateConsole();
        }
    }
}
