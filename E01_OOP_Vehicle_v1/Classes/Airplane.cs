﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;
using E01_OOP_Vehicle_v1.Interfaces;

namespace E01_OOP_Vehicle_v1.Classes
{
    internal class Airplane : Vehicle, IVehicleAir
    {
        #region Properties

        public string PlaneRegistration { get; set; }
        public double CurrentAltitude { get; set; }
        public double MaxAltitude { get; }
        public EnumAirVehicleBrand AirVehicleBrand { get; set; }
        public EnumAirVehicleModel AirVehicleModel { get; set; }
        public EnumAirVehicleType AirVehicleType { get; set; }

        public override string FullVehicle => $"Vehicle nº: {VehicleId}\nFabrication year: {VehicleYear}\nPlane registration: {PlaneRegistration}\nCurrent speed: {CurrentSpeed}\nMaximum speed: {MaxSpeed}\nCurrent altitude: {CurrentAltitude}\nMax altitude: {MaxAltitude:F3} feet\nBrand: {AirVehicleBrand}\nModel: {AirVehicleModel}\nType: {AirVehicleType}.";

        #endregion


        #region Constructors

        public Airplane() : base()
        { 
            PlaneRegistration = "N00000";
            MaxSpeed = 900;
            MaxAltitude = 45.000;
            AirVehicleBrand = EnumAirVehicleBrand.Embraer;
            AirVehicleModel = EnumAirVehicleModel.Phenom;
            AirVehicleType = EnumAirVehicleType.Airplane;
        }

        public Airplane(int vehicleYear, string planeRegistration, EnumAirVehicleBrand airVehicleBrand, EnumAirVehicleModel airVehicleModel, EnumAirVehicleType airVehicleType) : base(vehicleYear)
        {
            PlaneRegistration = planeRegistration;
            MaxSpeed = 900;
            MaxAltitude = 45.000;
            AirVehicleBrand = airVehicleBrand;
            AirVehicleModel = airVehicleModel;
            AirVehicleType = airVehicleType;
        }

        #endregion


        #region Methods
        // Polimorphism with Inheritance and Override method
        // Override the Vehicle method adding Airplane properties

        public override void CreateVehicle()
        {
            base.CreateVehicle();

            #region PlaneRegistration

            string planeRegistration;
            do
            {
                Utility.WriteMessage("Registration: ");
                planeRegistration = Console.ReadLine();

                if (planeRegistration != string.Empty)
                {
                    PlaneRegistration = planeRegistration;
                }
                else
                {
                    Utility.WriteMessage("You need to enter the registration.", "\n", "\n");
                    Utility.PauseConsole();
                }

            } while (planeRegistration == string.Empty);


            #endregion

            #region AirVehicleModel

            Utility.WriteMessage("Model: ");

            string model = Console.ReadLine();

            if (Enum.TryParse(model, true, out EnumAirVehicleModel planeModel))
            {
                AirVehicleModel = planeModel;
            }
            else
            {
                Utility.WriteMessage($"Invalid model entered. The default model will be set: {EnumAirVehicleModel.Phenom}", "\n", "\n");
            }

            #endregion

            #region AirVehicleBrand

            Utility.WriteMessage("Brand: ");

            string brand = Console.ReadLine();

            if (Enum.TryParse(brand, true, out EnumAirVehicleBrand planeBrand)) 
            {
                AirVehicleBrand = planeBrand;
            }
            else 
            {
                Utility.WriteMessage($"Invalid brand entered. The default brand will be set: {EnumAirVehicleBrand.Embraer}", "\n", "\n");
            }

            #endregion

            #region AirVehicleType

            Utility.WriteMessage("Type: ");

            string type = Console.ReadLine();

            if (Enum.TryParse(type, true, out EnumAirVehicleType planeType))
            {
                AirVehicleType = planeType;
            }
            else
            {
                Utility.WriteMessage($"Invalid model entered. The default model will be set: {EnumAirVehicleType.Airplane}", "\n", "\n");
            }

            #endregion

        }


        // Polimorphism with Inheritance and Override method
        // Override the Vehicle method specifying the vehicle name
        public override void StartVehicle()
        {
            Utility.WriteMessage($"Starting {AirVehicleType}.", "\n", "\n");
        }


        // Polimorphism with Inheritance and Override method
        // Override the Vehicle method changing its speed and specifying the vehicle name
        public override void MoveVehicle()
        {
            CurrentSpeed = 280;

            Utility.WriteMessage($"{AirVehicleType} in movement, speed from 0km/h to: {CurrentSpeed}km/h.", "", "\n");

        }

        public void TakeOff()
        {
            CurrentAltitude = 35.000;
            
            Utility.WriteMessage($"The {AirVehicleType} is taking off and has gone from 0 feet to {CurrentAltitude:F3} feet.", "", "\n");
        }


        public void Land()
        {
            CurrentAltitude = 0.0;

            Utility.WriteMessage($"The {AirVehicleType} landed successfully.", "", "\n");
        }


        // Polimorphism with Inheritance and Override method
        // Override the Vehicle method changing its speed and specifying the vehicle name
        public override void StopVehicle()
        {
            Utility.WriteMessage($"The {AirVehicleType} is stopping, speed from {CurrentSpeed}km/h to: 0km/h.", "", "\n");

            CurrentSpeed = 0;
        }


        #endregion


    }
}
