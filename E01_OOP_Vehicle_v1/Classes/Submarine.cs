﻿using D00_Utility;
using E01_OOP_Vehicle_v1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle_v1.Classes
{
    internal class Submarine : Vehicle, IVehicleWater
    {
        #region Properties

        public string PennantNumber { get; set; }
        public double CurrentDepth { get; set; }
        public double MaxDepth { get; set; }
        public EnumWaterVehicleBrand WaterVehicleBrand { get; set; }
        public EnumWaterVehicleModel WaterVehicleModel { get; set; }
        public EnumWaterVehicleType WaterVehicleType { get; set; }

        public override string FullVehicle => $"{base.FullVehicle}\nPennant number: {PennantNumber}\nCurrent depth: {CurrentDepth}\nMaximum depth: {MaxDepth}.";
        #endregion

        #region Constructors

        public Submarine() : base() 
        {
            PennantNumber = "000000";
            CurrentDepth = 0.0;
            MaxDepth = 500.00;
            MaxSpeed = 60.00;
            WaterVehicleBrand = EnumWaterVehicleBrand.Beneteau;
            WaterVehicleModel = EnumWaterVehicleModel.Oceanis;
            WaterVehicleType = EnumWaterVehicleType.Submarine;
        }

        public Submarine(int vehicleYear, string pennantNumber, double currentDepth, EnumWaterVehicleBrand waterVehicleBrand, EnumWaterVehicleModel waterVehicleModel, EnumWaterVehicleType waterVehicleType) : base(vehicleYear)
        {
            PennantNumber = pennantNumber;
            CurrentDepth = currentDepth;
            MaxDepth = 500.00;
            MaxSpeed = 60.00;
            WaterVehicleBrand = waterVehicleBrand;
            WaterVehicleModel = waterVehicleModel;
            WaterVehicleType = waterVehicleType;
        }



        #endregion


        #region Methods

        public override void CreateVehicle()
        {
            Utility.WriteTitle("Create a Water Vehicle", "", "\n\n");

            #region WaterVehicleYear

            GetVehicleYear();

            #endregion

            #region WaterVehiclePennantNumber

            GetPennantNumber();

            #endregion

            #region WaterVehicleType

            GetWaterVehicleType();

            #endregion

            #region WaterVehicleBrand

            GetVehicleBrand();

            #endregion

            #region WaterVehicleModel

            GetVehicleModel();

            #endregion

        }

        public override void GetVehicleYear()
        {
            bool isYear;
            int year;

            do
            {
                Console.Clear();

                Utility.WriteTitle("Create Air Vehicles", "", "\n\n");

                Utility.WriteMessage("Air Vehicle fabrication year: ");

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

        internal void GetPennantNumber()
        {
            string pennantNumber;
            do
            {
                Utility.WriteMessage("Pennant number: ");
                pennantNumber = Console.ReadLine();

                if (pennantNumber != string.Empty)
                {
                    PennantNumber = pennantNumber;
                }
                else
                {
                    Utility.WriteMessage("You need to enter the pennant number.", "\n", "\n");
                    Utility.PauseConsole();
                }

            } while (pennantNumber == string.Empty);
        }

        internal void GetWaterVehicleType()
        {
            Utility.WriteMessage("Type: ");

            string type = Console.ReadLine();

            if (Enum.TryParse(type, true, out EnumWaterVehicleType waterType))
            {
                WaterVehicleType = waterType;
            }
            else
            {
                Utility.WriteMessage($"Invalid type entered. The default type will be set: {EnumWaterVehicleType.Submarine}", "\n", "\n\n");
            }
        }

        public override void GetVehicleBrand()
        {
            Utility.WriteMessage("Brand: ");

            string brand = Console.ReadLine();

            if (Enum.TryParse(brand, true, out EnumWaterVehicleBrand waterBrand))
            {
                WaterVehicleBrand = waterBrand;
            }
            else
            {
                Utility.WriteMessage($"Invalid brand entered. The default brand will be set: {EnumWaterVehicleBrand.Beneteau}", "\n", "\n\n");
            }
        }

        public override void GetVehicleModel()
        {
            Utility.WriteMessage("Model: ");

            string model = Console.ReadLine();

            if (Enum.TryParse(model, true, out EnumWaterVehicleModel waterModel))
            {
                WaterVehicleModel = waterModel;
            }
            else
            {
                Utility.WriteMessage($"Invalid model entered. The default model will be set: {EnumWaterVehicleModel.Oceanis}", "\n", "\n\n");
            }
        }


        public override void StartVehicle()
        {
            Utility.WriteMessage($"Starting the {WaterVehicleType}.", "\n", "\n");

        }

        // Polimorphism with Inheritance and Override method
        // Override the Vehicle method changing its speed and specifying the vehicle name
        public override void MoveVehicle()
        {
            CurrentSpeed = 60;

            Utility.WriteMessage($"{WaterVehicleType} in movement, speed from 0km/h to: {CurrentSpeed}km/h.", "", "\n");

        }

        public void Dive()
        {
            CurrentDepth = GetSubmarineDepth();

            Utility.WriteMessage($"Submarine is diving with a depth of {CurrentDepth} meters.", "", "\n");
        }

        internal double GetSubmarineDepth()
        {
            double depth;
            bool isDepth;

            do
            {
                Utility.WriteMessage("Depth: ");

                string answer = Console.ReadLine();

                isDepth = double.TryParse(answer, out depth);

                if (!CheckSubmarineDepth(depth))
                {
                    Utility.WriteMessage($"Maximum depth: {MaxDepth}km/h.");
                    Utility.PauseConsole();
                    isDepth = false;
                }

            } while (!isDepth);

            return depth;
        }

        internal bool CheckSubmarineDepth(double depth)
        {
            if (depth > MaxDepth)
            {
                return false;
            }
            return true;
        }

        public void Emerge()
        {
            CurrentDepth = 0.0;

            Utility.WriteMessage($"The {WaterVehicleType} emerged and reached the surface successfully.", "", "\n");

        }

        public override void StopVehicle()
        {
            Utility.WriteMessage($"The {WaterVehicleType} is stopping, speed from {CurrentSpeed}km/h to: 0km/h.", "", "\n");

            CurrentSpeed = 0;
        }

        public override void ListVehicle()
        {
            Utility.WriteTitle($"{WaterVehicleType} Information", "\n", "\n\n");

            Utility.WriteMessage($"{FullVehicle}", "", "\n");
        }

        #endregion




    }
}
