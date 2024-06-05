using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static D06_OOP_Interfaces.CourseSoftSkills;

namespace D06_OOP_Interfaces
{
    // v1: enum dentro do ficheiro do interface por que só será usada aqui

    /*
    Lista de linguas aceitas com data type Enum
    Enums por default são int e zero-based
        internal enum EnumLanguage
        {
            Portugues,  // 0
            Frances,    // 1
            Ingles      // 2
        }
     */

    // Herda propriedades e métodos da interface ICourse

    internal interface ICourseSoftSkills : ICourse
    {
        // declara intenção das propriedades que pertencem unicamente a ICourseSoftSkills

        #region Properties

        EnumLanguage Language { get; }

        double Price { get; }

        #endregion

    }
}
