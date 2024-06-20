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

        // métodos não devem ser implementados na classe abstrata, pois não temos informações suficientes para implementá-los, rever arquitetura do projeto para implementar corretamente nas classes filhas
        // métodos abstratos devem ser implementados nas classes filhas

        #region Methods

        public virtual void CreateVehicle()
        {
            Utility.WriteTitle("Create Vehicle", "", "\n\n");

            GetVehicleYear();
        }

        public void GetVehicleYear()
        {
            bool isYear;
            int year;

            do
            {
                Console.Clear();

                Utility.WriteTitle("Create Vehicle", "", "\n\n");

                Utility.WriteMessage("Vehicle fabrication year: ");

                string answer = Console.ReadLine();

                isYear = int.TryParse(answer, out year);

                if (!isYear)
                {
                    Utility.WriteMessage("Enter a valid year.", "\n", "\n");
                    Utility.PauseConsole();
                }
                else if (!VehicleUtility.CheckVehicleYear(year))
                {
                    Utility.WriteMessage($"Year range between 1950 and {DateTime.Now.Year}.", "\n", "\n");
                    Utility.PauseConsole();
                    isYear = false;
                }

            } while (!isYear);

            VehicleYear = year;
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

        public virtual void StartVehicle()
        {
            Utility.WriteMessage("Starting the vehicle.", "\n", "\n");
        }

        public abstract void StopVehicle();

        #endregion

    }
}
