using D00_Utility;
using E01_OOP_Vehicle_v1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region Air Vehicles
            
            Airplane plane01 = new Airplane();

            plane01.CreateVehicle();

            plane01.ListVehicle();

            plane01.StartVehicle();
            plane01.MoveVehicle();
            plane01.TakeOff();
            plane01.Land();
            plane01.StopVehicle();

            Airplane plane02 = new Airplane(1999, "N45632", EnumAirVehicleBrand.Boing, EnumAirVehicleModel.A350, EnumAirVehicleType.Airplane);

            plane02.ListVehicle();

            plane02.StartVehicle();
            plane02.MoveVehicle();
            plane02.TakeOff();
            plane02.Land();
            plane02.StopVehicle();
            
            #endregion

            #region Road Vehicles

            Car car01 = new Car();

            double speed = Car.GetCarSpeed();

            car01.CreateVehicle();

            car01.StartVehicle();
            car01.MoveVehicle(speed);
            car01.Honk();
            // car01.StopVehicle();
            car01.Park();
            

            car01.ListVehicle();

            

            #endregion




            Utility.TerminateConsole();
        }
    }
}
