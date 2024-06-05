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

        public double CurrentSpeed { get; set; }

        public double MaxSpeed { get; set; }

        public virtual string FullVehicle => $"Vehicle nº: {VehicleId}, Fabrication year: {VehicleYear}, Current speed: {CurrentSpeed}, Maximum speed: {MaxSpeed}, ";

        #endregion

        #region Constructors

        public Vehicle()
        {
            VehicleId = NextId++;
            VehicleYear = DateTime.Now.Year;
            CurrentSpeed = 0;
            MaxSpeed = 0;
        }

        public Vehicle(int vehicleYear)
        {
            VehicleId = NextId++;
            VehicleYear = vehicleYear;
            CurrentSpeed = 0;
            MaxSpeed = 0;
        }

        #endregion


        #region Methods

        public virtual void CreateVehicle()
        {
            Utility.WriteTitle("Create Vehicle", "", "\n\n");

            GetVehicleYear();
        }

        public void GetVehicleYear()
        {
            bool isInt, isCorrect = false;
            string year;

            do
            {
                Utility.WriteMessage("Vehicle fabrication year: ");

                year = Console.ReadLine();

                isInt = VehicleUtility.CheckInt(year);

                if (isInt)
                {
                    isCorrect = VehicleUtility.CheckVehicleYear(year);
                }
                else
                {
                    Utility.WriteMessage("Only numbers accepted.", "\n", "\n");
                }

            } while (!isCorrect);

            VehicleYear = Convert.ToInt32(year);
        }


        public virtual void MoveVehicle()
        {
            CurrentSpeed = 50;

            Utility.WriteMessage($"Vehicle in movement, speed from 0km/h to: {CurrentSpeed}km/h.", "", "\n");
        }

        public virtual void ListVehicle()
        {
            Utility.WriteTitle("Vehicle Information", "\n", "\n\n");

            Utility.WriteMessage($"{FullVehicle}", "", "\n");
        }

        public abstract void StartVehicle();

        public abstract void StopVehicle();

        #endregion

    }
}
