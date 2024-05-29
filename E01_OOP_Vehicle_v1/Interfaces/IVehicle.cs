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
        int NextId { get; }
        int VehicleYear { get; }

        #endregion

        #region IVehicleAir inherited

        EnumAirVehicleBrand AirVehicleBrand { get; }
        EnumAirVehicleModel AirVehicleModel { get; }

        #endregion

        #region IVehicleRoad inherited

        EnumRoadVehicleBrand RoadVehicleBrand { get; }
        EnumRoadVehicleModel RoadVehicleModel { get; }

        #endregion

        #region IVehicleWater inherited

        EnumWaterVehicleBrand WaterVehicleBrand { get; }
        EnumWaterVehicleModel WaterVehicleModel { get; }

        #endregion


        #endregion


        #region Methods

        void CreateVehicle();
        void StartVehicle();
        void MoveVehicle();
        void StopVehicle();

        #endregion
    }
}
