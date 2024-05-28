using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06_OOP_Interfaces
{
    // Herda propriedades e métodos da classe Course e da interface ICourseSoftSkills

    internal class CourseSoftSkills : Course, ICourseSoftSkills
    {
        #region Enums (public or internal) 

        // Lista de linguas aceitas o data type Enum
        // Enums por dafault são int e zero-based
        internal enum EnumLanguage
        {
            Portugues,  // 0
            Frances,    // 1
            Ingles      // 2
        }

        #endregion


        #region Properties

        // implanta as propriedades que pertencem unicamente a ICourseSoftSkills

        public EnumLanguage Language { get; set; }

        #endregion


    }
}
