using E01_OOP_Vehicle_v1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle_v1.Classes
{
    internal abstract class Vehicle : IVehicle
    {
        #region Properties

        public int VehicleId { get; }

        internal static int NextId { get; set; } = 1;

        public int VehicleYear { get; set; }

        public EnumAirVehicleBrand AirVehicleBrand { get; set; }

        public EnumAirVehicleModel AirVehicleModel { get; set; }

        public EnumRoadVehicleBrand RoadVehicleBrand { get; set; }

        public EnumRoadVehicleModel RoadVehicleModel { get; set; }

        public EnumWaterVehicleBrand WaterVehicleBrand { get; set; }

        public EnumWaterVehicleModel WaterVehicleModel { get; set; }

        #endregion

        #region Constructors

        public Vehicle()
        {
            VehicleId = NextId++;
            VehicleYear = DateTime.Now.Year;
            AirVehicleBrand = EnumAirVehicleBrand.Embraer;
            AirVehicleModel = EnumAirVehicleModel.Phenom;
            RoadVehicleBrand = EnumRoadVehicleBrand.Mercedez;
            RoadVehicleModel = EnumRoadVehicleModel.EQC;
            WaterVehicleBrand = EnumWaterVehicleBrand.Beneteau;
            WaterVehicleModel = EnumWaterVehicleModel.Sundancer;
        }


        public Vehicle(int vehicleId, int vehicleYear, EnumAirVehicleBrand airVehicleBrand, EnumAirVehicleModel airVehicleModel, EnumRoadVehicleBrand roadVehicleBrand, EnumRoadVehicleModel roadVehicleModel, EnumWaterVehicleBrand waterVehicleBrand, EnumWaterVehicleModel waterVehicleModel)
        {
            VehicleId = vehicleId;
            VehicleYear = vehicleYear;
            AirVehicleBrand = airVehicleBrand;
            AirVehicleModel = airVehicleModel;
            RoadVehicleBrand = roadVehicleBrand;
            RoadVehicleModel = roadVehicleModel;
            WaterVehicleBrand = waterVehicleBrand;
            WaterVehicleModel = waterVehicleModel;
        }


        #endregion


        #region Methods

        public void CreateVehicle()
        {
            
        }

        public void MoveVehicle()
        {
            
        }

        public abstract void MoveVehicle(double speed);

        public void StartVehicle()
        {
            
        }

        public void StopVehicle()
        {
            
        }

        #endregion

    }
}
