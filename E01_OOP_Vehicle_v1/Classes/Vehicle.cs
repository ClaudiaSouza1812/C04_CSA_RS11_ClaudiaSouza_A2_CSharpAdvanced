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

        private static int NextId { get; set; } = 1;

        public int VehicleYear { get; set; }

        public EnumWaterVehicleBrand WaterVehicleBrand { get; set; }

        public EnumWaterVehicleModel WaterVehicleModel { get; set; }

        public double CurrentSpeed { get; set; }

        public double MaxSpeed { get; set; }

        public virtual string FullVehicle => $"Vehicle nº: {VehicleId}, Fabrication year: {VehicleYear}, ";

        #endregion

        #region Constructors

        public Vehicle()
        {
            VehicleId = NextId++;
            VehicleYear = DateTime.Now.Year;
        }

        public Vehicle(int vehicleYear)
        {
            VehicleId = NextId++;
            VehicleYear = vehicleYear;
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
                    converted = false;
                    Utility.WriteMessage("Only numbers accepted.", "\n", "\n");
                    Utility.WriteMessage($"Year range between 1950 and {DateTime.Now.Year}.", "\n", "\n");
                    Utility.PauseConsole();
                }

            } while (!converted);
        }

        public virtual void MoveVehicle()
        {
            CurrentSpeed = 50;

            Utility.WriteMessage($"Vehicle in movement, speed from 0km/h to: {CurrentSpeed}km/h.", "", "\n");
        }

        public virtual void ListVehicle()
        {
            Utility.WriteTitle("Vehicle Information", "\n", "\n\n");

            Utility.WriteMessage($"{FullVehicle}");
        }

        public abstract void StartVehicle();

        public abstract void StopVehicle();

        #endregion

    }
}
