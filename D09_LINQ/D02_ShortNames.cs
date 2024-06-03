using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D09_LINQ
{
    internal class D02_ShortNames
    {
        private static List<string> namesList = new List<string>();

        internal static void CreateListNames()
        {

            namesList.Add("Claudia");
            namesList.Add("Denise");
            namesList.Add("Antonia");
            namesList.Add("Eulália");
            namesList.Add("Eduardo");
            namesList.Add("Olívia");
            namesList.Add("Mel");
            namesList.Add("Sarah");
            namesList.Add("Paula");
            namesList.Add("Kelly");
            namesList.Add("Jonatan");
            namesList.Add("Cida");
        }

        internal static void ShortNamesMethodSyntax()
        {
            var shortNames01 = namesList.Where(n1 => n1.Length == namesList.Min(n2 => n2.Length));

            Utility.WriteTitle("Short Names Method Syntax", "", "\n\n");

            foreach (var shortName in shortNames01) 
            {
                Utility.WriteMessage(shortName, "\n");
            }
        }

        internal static void ShortNamesQuerySyntax()
        {
            #region v1: Com subquery e Min()

            var shortNames02 =
                from n1 in namesList
                where n1.Length == namesList.Min(n2 => n2.Length)
                select n1;

            Utility.WriteTitle("Short Names Query Syntax", "", "\n\n");

            foreach (var shortName in shortNames02)
            {
                Utility.WriteMessage(shortName, "\n");
            }

            #endregion

            #region v1: Com subquery e First()
        }


    }
}
