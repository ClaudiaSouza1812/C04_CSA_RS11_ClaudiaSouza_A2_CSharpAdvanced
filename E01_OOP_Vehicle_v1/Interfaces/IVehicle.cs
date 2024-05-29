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

        #region IVehicle own properties to be inherited by other interfaces and classes

        int VehicleId { get; }
        int VehicleYear { get; }

        #endregion

        #region Methods

        void CreateVehicle();
        void StartVehicle();
        void MoveVehicle();
        void StopVehicle();


        #endregion
    }
}
