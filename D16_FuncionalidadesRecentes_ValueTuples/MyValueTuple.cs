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
            // Console.WriteLine("{0}, {1}", student.Item1, student.Item2);
        }

        internal static (int, string, string) ReturnValueTuple()
        { 
            return (1, "Claudia", "Coimbra");
        }

        // CalculateValueTuple
        //      receber um tuple de 2 inteiros
        //      devolver um tuple de 4 inteiros, com o resultado das 4 operações aritméticas
        //      no Program, listar o resultado das 4 operações aritméticas

        internal static (int, int, int, double) ReturnArithmeticOperationsValueTuple((int, int) values)
        { 
            return (values.Item1 + values.Item2, values.Item1 - values.Item2, values.Item1 * values.Item2, values.Item1 / values.Item2);
        }
    }
}
