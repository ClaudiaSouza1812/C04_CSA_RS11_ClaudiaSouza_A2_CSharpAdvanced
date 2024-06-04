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

        public override string FullVehicle => $"Vehicle nº: {VehicleId}, Fabrication year: {VehicleYear}, Pennant number: {PennantNumber}, Current depth: {CurrentDepth}, ";
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

        public override void StartVehicle()
        {
            Utility.WriteMessage($"Starting the {WaterVehicleType}.", "\n\n", "\n");

        }


        // Polimorphism with Inheritance and Override method
        // Override the Vehicle method changing its speed and specifying the vehicle name
        public override void MoveVehicle()
        {
            CurrentSpeed = 280;

            Utility.WriteMessage($"{WaterVehicleType} in movement, speed from 0km/h to: {CurrentSpeed}km/h.", "", "\n");

        }


        public override void StopVehicle()
        {
            Utility.WriteMessage($"The {WaterVehicleType} is stopping, speed from {CurrentSpeed}km/h to: 0km/h.", "", "\n");

            CurrentSpeed = 0;
        }

        public void Dive()
        {
            CurrentDepth = GetSubmarineDepth();

            Utility.WriteMessage($"Submarine is diveing with a depth of {CurrentDepth}.", "", "\n");
        }

        internal double GetSubmarineDepth()
        {
            double depth;
            string answer;
            bool status = false;

            do
            {
                Console.Clear();
                Utility.WriteTitle($"Depth", "", "\n");

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

        public void Emerge()
        {
            throw new NotImplementedException();
        }

        #endregion




    }
}
