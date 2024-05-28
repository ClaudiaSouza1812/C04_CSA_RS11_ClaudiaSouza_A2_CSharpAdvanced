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
        // má escolha: colocar a enum dentro da classe 
        #region Properties

        // implanta as propriedades que pertencem unicamente a ICourseSoftSkills

        public EnumLanguage Language { get; set; }

        #endregion


    }
}
