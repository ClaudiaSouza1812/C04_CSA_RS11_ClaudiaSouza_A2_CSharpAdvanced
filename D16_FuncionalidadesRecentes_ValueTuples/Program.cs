using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D16_FuncionalidadesRecentes_ValueTuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            DateTime data = new DateTime(1992, 12, 18);

            #region Value tuple simples


            var student01 = (Nome: "Claudia", Idade: 31, Localidade: "Coimbra", Nascimento: new DateTime(1992, 12, 18), Casada: true);
            var student02 = (Nome: "Simone", Idade: 31, Localidade: "Coimbra", Nascimento: data, Casada: true);
            var student03 = ("Claudia", 31, "Coimbra", data, true);
            var student04 = student02;

            Utility.WriteMessage($"Student01: {student01.Nascimento}", "", "\n");
            Utility.WriteMessage($"Student02: {student02.Nascimento}", "", "\n");
            Utility.WriteMessage($"Student03: {student03.Item4}", "", "\n");
            Utility.WriteMessage($"Student04: {student04.Nome}", "", "\n");

            #endregion

            #region Value tuple - Create

            ValueTuple<string, int, string, DateTime, bool> student05 = new ValueTuple<string, int, string, DateTime, bool>("Claudia", 31, "Coimbra", new DateTime(1992, 12, 18), true);

            ValueTuple<string, short, string> student06 = ValueTuple.Create("Claudia", (short)31, "Coimbra");

            (string, int) student07 = ("Claudia", 31);

            (string, int) student09 = ValueTuple.Create("Paula", 39);

            MyValueTuple.ListValueTuple(student07);

            var student8 = MyValueTuple.ReturnValueTuple();

            Utility.WriteMessage($"Student08: {student8.Item1}, {student8.Item2}, {student8.Item3}", "", "\n");

            var calculations = MyValueTuple.ReturnArithmeticOperationsValueTuple((10, 5));

            Utility.WriteMessage($"Soma: {calculations.Item1}, Subtração: {calculations.Item2}, Multiplicação: {calculations.Item3}, Divisão: {calculations.Item4}");

            #endregion

            
            Utility.TerminateConsole();
        }
    }
}
