using E01_OOP_Vehicle_v1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle_v1.Interfaces
{
    internal interface IVehicleWater
    {
        string PennantNumber { get; }
        double CurrentDepth { get; }
        double Depth { get; }
        EnumWaterVehicleBrand WaterVehicleBrand { get; }
        EnumWaterVehicleModel WaterVehicleModel { get; }
        EnumWaterVehicleType WaterVehicleType { get; }

        #region Methods

        void Dive();
        void Emerge();

        #endregion
    }
}
