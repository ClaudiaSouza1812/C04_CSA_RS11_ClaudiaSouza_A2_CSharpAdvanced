using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06_OOP_Interfaces
{
    internal class CourseSoftSkills : Course, ICourseSoftSkills
    {
        #region Enums (public or internal) 

        // Enums por dafault são int e zero-based
        internal enum EnumLanguage
        {
            Portugues,  // 0
            Frances,    // 1
            Ingles      // 2
        }

        #endregion

        #region Properties

        public EnumLanguage Language { get; set; }

        #endregion


    }
}
