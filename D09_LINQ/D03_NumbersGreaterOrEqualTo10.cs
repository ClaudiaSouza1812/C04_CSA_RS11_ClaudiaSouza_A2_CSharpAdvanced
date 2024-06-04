using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D09_LINQ
{
    internal class D03_NumbersGreaterOrEqualTo10
    {
        static List<int> listNumbers = new List<int>();

        internal static void CreateListNumbers()
        {
            // Gerar 10 números aleatórios entre 0 e 50

            var randomNumbers = new Random();

            for (int i = 0; i < 10; i++)
            {
                listNumbers.Add(randomNumbers.Next(0, 51));
            }

        }

        internal static void NumbersGreaterOrEqualTo10MethodSyntax()
        {
            var numbers = listNumbers.Where(n => n >= 10).OrderBy(n => n);

            Utility.WriteTitle("Numbers greater or equal to 10 - Method Syntax", "", "\n");

            foreach (var item in numbers)
            {
                Utility.WriteMessage($"{item}", "", "\n");
            }
        }

        internal static void NumbersGreaterOrEqualTo10QuerySyntax()
        {
            var numbers = 
                from n1 in listNumbers
                where n1 >= 10
                orderby n1
                select n1;

            Utility.WriteTitle("Numbers greater or equal to 10 - Query Syntax", "", "\n");

            foreach (var item in numbers)
            {
                Utility.WriteMessage($"{item}", "", "\n");
            }

        }
    }
}
