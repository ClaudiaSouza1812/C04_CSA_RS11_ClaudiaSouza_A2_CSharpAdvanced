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

        #endregion

        #region Constructors

        public Car() : base()
        {
            CarRegistration = "000000";
            RoadVehicleBrand = EnumRoadVehicleBrand.Mercedez;
            RoadVehicleModel = EnumRoadVehicleModel.EQC;
            RoadVehicleColor = EnumRoadVehicleColor.Preto;
            RoadVehicleNumberOfDoors = EnumRoadVehicleNumberOfDoors.Cinco;
            CurrentSpeed = 0;
            MaxSpeed = 180;
        }

        public Car(int vehicleYear, string carRegistration, EnumRoadVehicleBrand roadVehicleBrand, EnumRoadVehicleModel roadVehicleModel, EnumRoadVehicleColor roadVehicleColor, EnumRoadVehicleNumberOfDoors roadVehicleNumberOfDoors) : base(vehicleYear)
        {
            CarRegistration = carRegistration;
            RoadVehicleBrand = roadVehicleBrand;
            RoadVehicleModel = roadVehicleModel;
            RoadVehicleColor = roadVehicleColor;
            RoadVehicleNumberOfDoors = roadVehicleNumberOfDoors;
            CurrentSpeed = 0;
            MaxSpeed = 180;
        }



        #endregion

        public override void StartVehicle()
        {
            Utility.WriteMessage("Starting the Car.", "\n\n", "\n");
        }

        public void Honk()
        {
            throw new NotImplementedException();
        }

        // Polimorphism with Inheritance and Overloading methods
        // Override the Vehicle method changing its speed and specifying the vehicle name
        public override void MoveVehicle()
        {
            CurrentSpeed = 50;

            Utility.WriteMessage($"Car in movement, speed from 0km/h to: {CurrentSpeed}km/h.", "", "\n");

        }

        public void MoveVehicle(double speed)
        {
            string answer;
            bool status;
            do
            {
                Console.Clear();
                Utility.WriteMessage("Speed: ");
                answer = Console.ReadLine();
                status = double.TryParse(answer, out speed);

                if (!status || speed > MaxSpeed)
                {
                    Utility.WriteMessage($"Maximum speed: {MaxSpeed}km/h.");
                }

            } while (!status || speed > MaxSpeed);

            CurrentSpeed = speed;

        }

        
        public void Park()
        {
            throw new NotImplementedException();
        }

        public override void StopVehicle()
        {
            throw new NotImplementedException();
        }
    }
}
