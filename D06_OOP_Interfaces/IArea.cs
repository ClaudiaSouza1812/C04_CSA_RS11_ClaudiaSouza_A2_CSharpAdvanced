using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06_OOP_Interfaces
{
    // 2º interface a ser feita, o nome reflete o módulo principal

    internal interface IArea
    {
        #region Properties

        // Declara intenção das propriedades (só recebem valor, não implementam (set) valores) que pertencem a IArea

        int AreaId { get; }
        string AreaName { get; }
        string SubareaName { get; }
        string Description { get; }

        #endregion

        
    }
}
