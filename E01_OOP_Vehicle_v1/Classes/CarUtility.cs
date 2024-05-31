using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Vehicle_v1.Classes
{
    internal class CarUtility : Car
    {
        internal static double GetCarSpeed()
        {
            double speed;
            string answer;
            bool status = false;

            do
            {
                Console.Clear();
                Utility.WriteTitle("Car Speed", "", "\n");

                Utility.WriteMessage("Enter speed: ");

                answer = Console.ReadLine();

                if (CheckDouble(answer))
                {
                    status = CheckCarSpeed(answer);
                }

            } while (!status);

            speed = Convert.ToDouble(answer);

            return speed;
        }

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
