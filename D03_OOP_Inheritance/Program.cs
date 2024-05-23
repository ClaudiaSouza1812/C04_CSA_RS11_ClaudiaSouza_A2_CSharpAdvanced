using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            CourseIT courseIT01 = new CourseIT();

            courseIT01.ReadCourse();

            courseIT01.ListCourse();


            Utility.TerminateConsole();
        }
    }
}
