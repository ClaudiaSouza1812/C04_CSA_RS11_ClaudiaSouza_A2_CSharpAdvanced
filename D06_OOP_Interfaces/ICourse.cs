using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06_OOP_Interfaces
{
    // 1º interface a ser feita
    internal interface ICourse
    {
        #region Properties (public or internal)

        // Declaração de intenção das propriedades (só recebem valor, não implementam (set) valor)
        int CourseId { get; }
        string Name { get; }
        int FullCourse {  get; }

        #endregion

        #region Methods

        // Declaração de intenção dos métodos (só podem ser void ou não void, sem implementação)
        void ReadCourse();
        void ListCourse(string level);
        void ListCourse(DateTime timestamp);

        #endregion
    }
}
