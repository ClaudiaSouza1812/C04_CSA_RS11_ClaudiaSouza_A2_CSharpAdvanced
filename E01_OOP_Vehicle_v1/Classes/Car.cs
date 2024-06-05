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

        public override string FullVehicle => $"Vehicle nº: {VehicleId}\nFabrication year: {VehicleYear}\nCar registration: {CarRegistration}\nCurrent speed: {CurrentSpeed}\nMaximum speed: {MaxSpeed}\nBrand: {RoadVehicleBrand}\nModel: {RoadVehicleModel}\nColor: {RoadVehicleColor}\nDoors: {RoadVehicleNumberOfDoors}.";

        #endregion

        #region Constructors

        public Car() : base()
        {
            CarRegistration = "000000";
            RoadVehicleBrand = EnumRoadVehicleBrand.Mercedez;
            RoadVehicleModel = EnumRoadVehicleModel.EQC;
            RoadVehicleColor = EnumRoadVehicleColor.Preto;
            RoadVehicleNumberOfDoors = EnumRoadVehicleNumberOfDoors.Quatro;
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

        public override void CreateVehicle()
        {
            base.CreateVehicle();

            #region CarRegistration

            string carRegistration;
            do
            {
                Utility.WriteMessage("Car registration: ");
                carRegistration = Console.ReadLine();

                if (carRegistration != string.Empty)
                {
                    CarRegistration = carRegistration;
                }
                else
                {
                    Utility.WriteMessage("You need to enter the car registration.", "\n", "\n");
                    Utility.PauseConsole();
                }

            } while (carRegistration == string.Empty);


            #endregion

            #region RoadVehicleBrand

            Utility.WriteMessage("Brand: ");

            string brand = Console.ReadLine();

            if (Enum.TryParse(brand, true, out EnumRoadVehicleBrand carBrand))
            {
                RoadVehicleBrand = carBrand;
            }
            else
            {
                Utility.WriteMessage($"Invalid brand entered. The default brand will be set: {EnumRoadVehicleBrand.Mercedez}", "\n", "\n");
            }

            #endregion

            #region RoadVehicleModel

            Utility.WriteMessage("Model: ");

            string model = Console.ReadLine();

            if (Enum.TryParse(model, true, out EnumRoadVehicleModel carModel))
            {
                RoadVehicleModel = carModel;
            }
            else
            {
                Utility.WriteMessage($"Invalid model entered. The default model will be set: {EnumRoadVehicleModel.EQC}", "\n", "\n");
            }

            #endregion

            #region RoadVehicleColor

            Utility.WriteMessage("Color: ");

            string color = Console.ReadLine();

            if (Enum.TryParse(color, true, out EnumRoadVehicleColor carColor))
            {
                RoadVehicleColor = carColor;
            }
            else
            {
                Utility.WriteMessage($"Invalid color entered. The default color will be set: {EnumRoadVehicleColor.Prata}", "\n", "\n");
            }

            #endregion

            #region RoadVehicleNumberOfDoors

            Utility.WriteMessage("Enter the number of doors, ex: (quatro).","\n", "\n");
            Utility.WriteMessage("Number Of Doors: ");

            string doors = Console.ReadLine();

            if (Enum.TryParse(doors, true, out EnumRoadVehicleNumberOfDoors carDoors))
            {
                RoadVehicleNumberOfDoors = carDoors;
            }
            else
            {
                Utility.WriteMessage($"Invalid number of doors entered. The default number of doors will be set: {EnumRoadVehicleNumberOfDoors.Quatro}", "\n", "\n");
            }

            #endregion

        }


        public override void StartVehicle()
        {
            Utility.WriteMessage("Starting the Car.", "\n\n", "\n");
        }


        internal static double GetCarSpeed()
        {
            string speed;
            bool isDouble, isCorrect = false;

            do
            {
                Console.Clear();
                Utility.WriteTitle("Car Speed", "", "\n");

                Utility.WriteMessage("Enter speed: ");

                speed = Console.ReadLine();

                isDouble = VehicleUtility.CheckDouble(speed);

                if (isDouble)
                {
                    isCorrect = CheckCarSpeed(speed);
                }

            } while (!isCorrect);

            return Convert.ToDouble(speed);
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
