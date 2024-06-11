using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15_CSharpAdvanced_Async
{
    internal class ClassAsync02
    {
        internal static async Task Task04(string nome, int delay)
        {
            Console.WriteLine($"Início da task{nome} \n\n");

            await Task.Delay(delay);

            Console.WriteLine($"Fim das tasks \n\n");
        }
    }
}
