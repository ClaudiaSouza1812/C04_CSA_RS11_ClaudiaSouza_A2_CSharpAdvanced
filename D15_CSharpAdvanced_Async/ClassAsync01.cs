using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15_CSharpAdvanced_Async
{
    internal class ClassAsync01  // Backgroud thread
    {
        internal static async Task Task01()
        {
            Console.WriteLine($"Início da task01 \n\n");

            await Task.Delay(1000);

            Console.WriteLine($"Fim da task01 \n\n");
        }

        internal static async Task Task02()
        {
            Console.WriteLine($"Início da task02 \n\n");

            await Task.Delay(4000);

            Console.WriteLine($"Fim da task02 \n\n");
        }

        internal static async Task Task03()
        {
            for (int i = 0, j = 1; i < 2; i++, j = j + 3)
            {
                Console.WriteLine($"Início da task0{i + 1} \n\n");

                await Task.Delay(j * 1000);
            }
            
            Console.WriteLine($"Fim das tasks \n\n");
        }

        
    }
}
