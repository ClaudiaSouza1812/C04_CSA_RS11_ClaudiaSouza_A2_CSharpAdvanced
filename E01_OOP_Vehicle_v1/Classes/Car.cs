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

        

        public double MaxSpeed { get; }

        #endregion
        






        public override void StartVehicle()
        {
            throw new NotImplementedException();
        }

        public void Honk()
        {
            throw new NotImplementedException();
        }

        public void MoveVehicle(double speed)
        {
            throw new NotImplementedException();
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
