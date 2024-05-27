using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06_OOP_Interfaces
{
    internal interface IArea
    {
        #region Properties

        int AreaId { get; }
        string AreaName { get; }
        string SubareaName { get; }
        string Description { get; }

        #endregion

        #region Methods



        #endregion
    }
}
