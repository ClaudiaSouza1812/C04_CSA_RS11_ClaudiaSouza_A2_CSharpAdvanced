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
        public string PennantNumber => throw new NotImplementedException();

        public double CurrentDepth => throw new NotImplementedException();

        public double Depth => throw new NotImplementedException();

        public EnumWaterVehicleType WaterVehicleType => throw new NotImplementedException();

        public override void StartVehicle()
        {
            throw new NotImplementedException();
        }

        public override void StopVehicle()
        {
            throw new NotImplementedException();
        }

        public void Dive()
        {
            throw new NotImplementedException();
        }

        public void Emerge()
        {
            throw new NotImplementedException();
        }

        
    }
}
