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

        internal static bool CheckInt(string answer)
        {
            bool status = int.TryParse(answer, out int year);

            if (!status)
            {
                Utility.WriteMessage("Only integer numbers are accepted.", "", "\n");
                Utility.PauseConsole();
                return status;
            }

            return status;
        }

        public static bool CheckVehicleYear(string answer)
        {
            int year = Convert.ToInt32(answer);

            if (year > 1950 && year < DateTime.Today.Year)
            {
                return true;
            }
            else
            {
                Utility.WriteMessage($"Year range between 1950 and {DateTime.Now.Year}.", "\n", "\n");
                Utility.PauseConsole();
                return false;
            }
        }
    }
}
