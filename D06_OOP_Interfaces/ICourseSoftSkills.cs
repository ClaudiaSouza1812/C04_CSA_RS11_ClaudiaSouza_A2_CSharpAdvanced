using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static D06_OOP_Interfaces.CourseSoftSkills;

namespace D06_OOP_Interfaces
{
    internal interface ICourseSoftSkills : ICourse
    {
        #region Properties

        EnumLanguage Language { get; }

        #endregion

    }
}
