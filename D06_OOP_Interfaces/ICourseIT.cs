using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06_OOP_Interfaces
{
    // Herda propriedades e métodos da interface ICourse

    internal interface ICourseIT : ICourse
    {
        // declara intenção das propriedades que pertencem unicamente a ICourseIT
        #region Properties

        bool Exam { get; }

        double Price { get; }

        #endregion
    }
}
