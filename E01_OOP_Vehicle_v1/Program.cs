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

            Airplane plane01 = new Airplane();

            //plane01.CreateVehicle();
            plane01.ListVehicle();

            plane01.StartVehicle();
            plane01.MoveVehicle();
            plane01.TakeOff();
            plane01.Land();
            plane01.StopVehicle();

            Utility.TerminateConsole();
        }
    }
}
