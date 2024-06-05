using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle_v1.Classes
{
    /*
    internal enum EnumVehicleBrand
    {
        Embraer,
        Boeing,
        Porsche,
        Mercedes,
        Naval,
        Beneteau
    }

    internal enum EnumVehicleModel
    {
        Phenom,
        A350,
        Beluga,
        Macan,
        Cayenne,
        EQC,
        VirginiaClass,
        Oceanis,
        Sundancer
    }
    */
    #region Air Vehicles

    internal enum EnumAirVehicleBrand
    {
        Embraer,
        Boing
    }

    internal enum EnumAirVehicleModel
    {
        Phenom,
        A350,
        Beluga
    }

    internal enum EnumAirVehicleType
    {
        Airplane,
        Helicopter,
        Glider,
        Balloon,
        Drone,
    }

    #endregion

    #region Road Vehicles

    internal enum EnumRoadVehicleBrand
    {
        Porsche,
        Mercedez
    }

    internal enum EnumRoadVehicleModel
    {
        Macan,
        Cayenne,
        EQC
    }

    internal enum EnumRoadVehicleColor
    {
        Preto,
        Prata,
        Cinza,
        Branco,
        Azul
    }

    internal enum EnumRoadVehicleNumberOfDoors
    {
        Duas,
        Três,
        Quatro
    }


    #endregion

    #region Water Vehicles

    internal enum EnumWaterVehicleBrand
    {
        Naval,
        Beneteau
    }

    internal enum EnumWaterVehicleModel
    {
        VirginiaClass,
        Oceanis,
        Sundancer
    }

    internal enum EnumWaterVehicleType
    {
        Submarine,
        Ship,
        Yacht
    }
    #endregion







}
