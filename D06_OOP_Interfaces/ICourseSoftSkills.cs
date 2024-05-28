using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static D06_OOP_Interfaces.CourseSoftSkills;

namespace D06_OOP_Interfaces
{
    // Herda propriedades e métodos da interface ICourse

    internal interface ICourseSoftSkills : ICourse
    {
        // declara intenção das propriedades que pertencem unicamente a ICourseSoftSkills

        #region Properties

        EnumLanguage Language { get; }

        #endregion

    }
}
