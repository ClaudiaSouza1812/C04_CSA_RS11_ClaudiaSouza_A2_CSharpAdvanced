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

        public virtual string FullVehicle => $"Vehicle nº: {VehicleId}\nFabrication year: {VehicleYear}\nCurrent speed: {CurrentSpeed}\nMaximum speed: {MaxSpeed}";

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

        public abstract void CreateVehicle();

        public abstract void StartVehicle();

        public abstract void MoveVehicle();

        public abstract void GetVehicleYear();

        public abstract void StopVehicle();

        public abstract void ListVehicle();

        public abstract void GetVehicleBrand();

        public abstract void GetVehicleModel();

        

        #endregion

    }
}
