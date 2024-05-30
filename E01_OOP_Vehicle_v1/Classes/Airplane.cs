using System;
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

        public double MaxAltitude { get; set; }

        public EnumAirVehicleBrand AirVehicleBrand { get; set; }

        public EnumAirVehicleModel AirVehicleModel { get; set; }

        public EnumAirVehicleType AirVehicleType { get; set; }

        public override string FullVehicle => $"Vehicle nº: {VehicleId}\nFabrication year: {VehicleYear}\nPlane registration: {PlaneRegistration}\nMax altitude: {MaxAltitude:F3} feet\nBrand: {AirVehicleBrand}\nModel: {AirVehicleModel}\nType: {AirVehicleType}.";

        private int speed;

        #endregion


        #region Constructors

        public Airplane() : base()
        { 
            PlaneRegistration = string.Empty;
            CurrentAltitude = 0.0;
            MaxAltitude = 45.000;
            AirVehicleBrand = EnumAirVehicleBrand.Embraer;
            AirVehicleModel = EnumAirVehicleModel.Phenom;
            AirVehicleType = EnumAirVehicleType.Airplane;
        }

        public Airplane(int vehicleYear, string planeRegistration, double currentAltitude, EnumAirVehicleBrand airVehicleBrand, EnumAirVehicleModel airVehicleModel, EnumAirVehicleType airVehicleType) : base(vehicleYear)
        {
            PlaneRegistration = planeRegistration;
            CurrentAltitude = currentAltitude;
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
                Utility.WriteMessage("Plane registration: ");
                planeRegistration = Console.ReadLine();

                if (planeRegistration != string.Empty)
                {
                    PlaneRegistration = planeRegistration;
                }
                else
                {
                    Utility.WriteMessage("You need to enter the plane registration.", "\n", "\n");
                    Utility.PauseConsole();
                }

            } while (planeRegistration == string.Empty);

            
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
        // Override the Vehicle method changing its speed and specifying the vehicle name
        public override void MoveVehicle()
        {
            speed = 280;

            Utility.WriteMessage($"Airplane in movement, speed from 0km/h to: {speed}km/h.", "", "\n");

        }


        public void TakeOff()
        {
            CurrentAltitude = 35.000;
            
            Utility.WriteMessage($"The plane is taking off and has gone from 0 feet to {CurrentAltitude:F3} feet.", "", "\n");
        }


        public void Land()
        {
            CurrentAltitude = 0.0;

            Utility.WriteMessage("Plane landed with success.", "", "\n");
        }

        // Polimorphism with Inheritance and Override method
        public override void StopVehicle()
        {
            Utility.WriteMessage($"Vehicle stopping, speed from {speed}km/h to: 0km/h.", "", "\n");

            speed = 0;
        }


        #endregion


    }
}
