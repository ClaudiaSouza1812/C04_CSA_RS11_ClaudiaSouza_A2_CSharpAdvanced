using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15_CSharpAdvanced_Async
{
    internal class Program
    {
        
        static async Task Main(string[] args) // Main thread --> async
        {
            /*
            #region Async01
            // Start the two tasks
            Task task01 = ClassAsync01.Task01();
            Task task02 = ClassAsync01.Task02();

            // Wait for the tasks to finish
            await Task.WhenAll(task01, task02);

            Console.WriteLine("Tarefas terminadas", "", "\n");

            #endregion
            */
            #region Async02

            Task task03 = ClassAsync02.Task04("03", 1000);
            Task task04 = ClassAsync02.Task04("04", 4000);
            
            await Task.WhenAll(task03, task04);

            Console.WriteLine("Tarefas terminadas", "", "\n");

            #endregion


            Console.ReadKey();
        }
    }
}
