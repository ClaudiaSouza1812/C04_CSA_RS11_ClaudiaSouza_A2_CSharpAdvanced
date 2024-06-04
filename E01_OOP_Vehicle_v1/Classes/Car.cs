using D00_Utility;
using E01_OOP_Vehicle_v1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle_v1.Classes
{
    internal class Car : Vehicle, IVehicleRoad
    {
        #region Properties

        public string CarRegistration { get; set; }
        public EnumRoadVehicleBrand RoadVehicleBrand { get; set; }
        public EnumRoadVehicleModel RoadVehicleModel { get; set; }
        public EnumRoadVehicleColor RoadVehicleColor { get; set; }
        public EnumRoadVehicleNumberOfDoors RoadVehicleNumberOfDoors { get; set; }
        public static new double MaxSpeed { get; set; }

        public override string FullVehicle => $"Vehicle nº: {VehicleId}\nFabrication year: {VehicleYear}\nPlane registration: {CarRegistration}\nCurrent speed: {CurrentSpeed}\nMaximum speed: {MaxSpeed}\nBrand: {RoadVehicleBrand}\nModel: {RoadVehicleModel}\nColor: {RoadVehicleColor}\nDoors: {RoadVehicleNumberOfDoors}.";

        #endregion

        #region Constructors

        public Car() : base()
        {
            CarRegistration = "000000";
            RoadVehicleBrand = EnumRoadVehicleBrand.Mercedez;
            RoadVehicleModel = EnumRoadVehicleModel.EQC;
            RoadVehicleColor = EnumRoadVehicleColor.Preto;
            RoadVehicleNumberOfDoors = EnumRoadVehicleNumberOfDoors.Cinco;
            MaxSpeed = 180;
        }

        public Car(int vehicleYear, string carRegistration, EnumRoadVehicleBrand roadVehicleBrand, EnumRoadVehicleModel roadVehicleModel, EnumRoadVehicleColor roadVehicleColor, EnumRoadVehicleNumberOfDoors roadVehicleNumberOfDoors) : base(vehicleYear)
        {
            CarRegistration = carRegistration;
            RoadVehicleBrand = roadVehicleBrand;
            RoadVehicleModel = roadVehicleModel;
            RoadVehicleColor = roadVehicleColor;
            RoadVehicleNumberOfDoors = roadVehicleNumberOfDoors;
            MaxSpeed = 180;
        }

        #endregion

        #region Methods

        public override void StartVehicle()
        {
            Utility.WriteMessage("Starting the Car.", "\n\n", "\n");
        }


        internal static double GetCarSpeed()
        {
            double speed;
            string answer;
            bool status = false;

            do
            {
                Console.Clear();
                Utility.WriteTitle("Car Speed", "", "\n");

                Utility.WriteMessage("Enter speed: ");

                answer = Console.ReadLine();

                if (VehicleUtility.CheckDouble(answer))
                {
                    status = CheckCarSpeed(answer);
                }

            } while (!status);

            speed = Convert.ToDouble(answer);

            return speed;
        }


        internal static bool CheckCarSpeed(string speed)
        {

            if (Convert.ToDouble(speed) > MaxSpeed)
            {
                Utility.WriteMessage($"Maximum speed: {MaxSpeed}km/h.");
                Utility.PauseConsole();
                return false;
            }
            return true;
        }


        // Polimorphism with Inheritance and Overloading 
        // Overloading method with different parameter (signature) and behavior.
        public void MoveVehicle(double speed)
        {
            CurrentSpeed = speed;

            Utility.WriteMessage($"Car in movement, speed from 0km/h to: {CurrentSpeed}km/h.", "", "\n");
        }


        // Polimorphism with Inheritance and Override
        // Override the Vehicle method changing its speed and specifying the vehicle name
        public override void MoveVehicle()
        {
            CurrentSpeed = 50;

            Utility.WriteMessage($"Car in movement, speed from 0km/h to: {CurrentSpeed}km/h.", "", "\n");

        }


        public void Honk()
        {
            Utility.WriteMessage($"The Car is honking.", "", "\n");
        }


        public void Park()
        {
            Utility.WriteMessage($"The Car is parking, speed from {CurrentSpeed}km/h to: 0km/h.", "", "\n");

            CurrentSpeed = 0;
        }


        public override void StopVehicle()
        {
            Utility.WriteMessage($"The Car is stopping, speed from {CurrentSpeed}km/h to: 0km/h.", "", "\n");

            CurrentSpeed = 0;
        }

        #endregion

    }
}
