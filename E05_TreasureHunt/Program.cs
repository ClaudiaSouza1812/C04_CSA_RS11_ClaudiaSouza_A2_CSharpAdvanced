using D00_Utility;
using E05_TreasureHunt.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_TreasureHunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Forest forest = new Forest();

            forest.CreateForest();


            Utility.TerminateConsole();
        }
    }
}
