using D00_Utility;
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


        public Vehicle(int vehicleYear, EnumAirVehicleBrand airVehicleBrand, EnumAirVehicleModel airVehicleModel, EnumRoadVehicleBrand roadVehicleBrand, EnumRoadVehicleModel roadVehicleModel, EnumWaterVehicleBrand waterVehicleBrand, EnumWaterVehicleModel waterVehicleModel)
        {
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

        public virtual void CreateVehicle()
        {
            bool converted;
            int year;

            do
            {
                Console.Clear();

                Utility.WriteMessage("Fabrication year: ");

                converted = int.TryParse(Console.ReadLine(), out year);

                if (converted && year > 1950 && year < DateTime.Today.Year)
                {
                    VehicleYear = year;
                }
                else
                {
                    Utility.WriteMessage("Only numbers accepted.", "\n", "\n");
                    Utility.WriteMessage($"Year range between 1950 and {DateTime.Now.Year}.", "\n", "\n");
                }

            } while (!converted);
        }

        public virtual void MoveVehicle()
        {
            int speed = 50;

            Utility.WriteMessage($"Vehicle in movement, velocity: {speed}km.", "", "\n");
        }

        public void StartVehicle()
        {
            Utility.WriteMessage("Starting vehicle.", "", "\n");
        }

        public void StopVehicle()
        {
            int speed = 0;

            Utility.WriteMessage($"Vehicle stopping, velocity: {speed}km.", "", "\n");
        }

        #endregion

    }
}
