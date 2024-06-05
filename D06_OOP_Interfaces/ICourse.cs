using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06_OOP_Interfaces
{
    // 1º interface a ser feita, o nome reflete o módulo principal
    internal interface ICourse
    {
        #region Properties (public or internal)

        // Declara intenção das propriedades (só recebem valor, não implementam (set) valores) que pertencem a ICourse
        int CourseId { get; }
        string Name { get; }
        string FullCourse {  get; }
        string SubareaName { get; }
        string Description { get; }

        #endregion

        #region Methods

        // Declara intenção dos métodos (só podem ser void ou não void, sem implementação) que pertencem a ICourse
        void ReadCourse();
        void ListCourse();
        void ListCourse(string level);
        void ListCourse(DateTime timestamp);
        void Billing(string status);

        #endregion
    }
}
