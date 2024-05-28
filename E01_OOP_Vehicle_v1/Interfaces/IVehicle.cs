using E01_OOP_Vehicle_v1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle_v1.Interfaces
{
    internal interface IVehicle
    {
        #region Properties (public or internal)

        int VehicleId { get; }
        int NextId { get; }
        EnumBrand Brand { get; }
        EnumModel Model { get; }
        int Year { get; }


        #endregion

        #region Methods

        #endregion
    }
}
