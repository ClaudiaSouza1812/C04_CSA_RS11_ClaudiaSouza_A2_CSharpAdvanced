using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D16_FuncionalidadesRecentes_ValueTuples
{
    internal class MyValueTuple
    {
        internal static void ListValueTuple((string, int) student)
        {
            Utility.WriteMessage($"Nome: {student.Item1}, Idade: {student.Item2}", "", "\n");
        }
    }
}
