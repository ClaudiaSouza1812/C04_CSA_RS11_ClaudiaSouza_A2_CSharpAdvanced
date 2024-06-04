using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle_v1.Classes
{
    internal class VehicleUtility
    {
        // Perguntar a Milena sobre CarUtility
        internal static bool CheckDouble(string answer)
        {
            bool status = double.TryParse(answer, out double CarSpeed);

            if (!status)
            {
                Utility.WriteMessage("Only numbers are accepted.", "", "\n");
                Utility.PauseConsole();
                return status;
            }

            return status;
        }
    }
}
