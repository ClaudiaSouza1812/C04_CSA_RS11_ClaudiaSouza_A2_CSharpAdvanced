using D00_Utility;
using E01_OOP_Vehicle_v1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public override string FullVehicle => $"Vehicle nº: {VehicleId}\nFabrication year: {VehicleYear}\nPennant number: {PennantNumber}\nCurrent depth: {CurrentDepth}\nMaximum depth: {MaxDepth}\nCurrent speed: {CurrentSpeed}\nMaximum speed: {MaxSpeed}.";
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
            base.CreateVehicle();

            #region PennantNumber

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


            #endregion

            #region WaterVehicleType

            Utility.WriteMessage("Type: ");

            string type = Console.ReadLine();

            if (Enum.TryParse(type, true, out EnumWaterVehicleType waterType))
            {
                WaterVehicleType = waterType;
            }
            else
            {
                Utility.WriteMessage($"Invalid model entered. The default model will be set: {EnumWaterVehicleType.Submarine}", "\n", "\n");
            }

            #endregion

            #region WaterVehicleBrand

            Utility.WriteMessage("Brand: ");

            string brand = Console.ReadLine();

            if (Enum.TryParse(brand, true, out EnumWaterVehicleBrand waterBrand))
            {
                WaterVehicleBrand = waterBrand;
            }
            else
            {
                Utility.WriteMessage($"Invalid brand entered. The default brand will be set: {EnumWaterVehicleBrand.Beneteau}", "\n", "\n");
            }

            #endregion

            #region WaterVehicleModel

            Utility.WriteMessage("Model: ");

            string model = Console.ReadLine();

            if (Enum.TryParse(model, true, out EnumWaterVehicleModel waterModel))
            {
                WaterVehicleModel = waterModel;
            }
            else
            {
                Utility.WriteMessage($"Invalid model entered. The default model will be set: {EnumWaterVehicleModel.Oceanis}", "\n", "\n");
            }

            #endregion

        }

        public override void StartVehicle()
        {
            Utility.WriteMessage($"Starting the {WaterVehicleType}.", "\n\n", "\n");

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

       
        internal double GetSubmarineDepth()
        {
            double depth;
            string answer;
            bool status = false;

            do
            {
                Utility.WriteMessage("Enter Depth: ");

                answer = Console.ReadLine();

                if (VehicleUtility.CheckDouble(answer))
                {
                    status = CheckSubmarineDepth(answer);
                }

            } while (!status);

            depth = Convert.ToDouble(answer);

            return depth;
        }


        internal bool CheckSubmarineDepth(string depth)
        {

            if (Convert.ToDouble(depth) > MaxDepth)
            {
                Utility.WriteMessage($"Maximum depth: {MaxDepth}km/h.");
                Utility.PauseConsole();
                return false;
            }
            return true;
        }

        

        #endregion




    }
}
