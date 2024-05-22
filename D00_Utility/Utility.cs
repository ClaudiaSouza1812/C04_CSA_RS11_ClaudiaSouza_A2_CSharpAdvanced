using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D00_Utility
{
    public class Utility
    {
        // Create a method to ensure that characters from any language, including special characters, can be correctly displayed in the console.
        // This is particularly useful when working with text that contains characters from languages other than English, as UTF-8 supports a wide range of characters and symbols.

        public static void SetUnicodeConsole()
        {
            // Console.WriteLine("á Á à À ã Ã â Â ç Ç º ª");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
        }

        // Create a method to show a stylish title
        public static void WriteTitle(string title, string beginTitle = "", string endTitle = "")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{beginTitle}{new string('-', title.Length)}\n{title.ToUpper()}\n{new string('-', title.Length)}{endTitle}");
            Console.ForegroundColor = ConsoleColor.White;   // Reset original color
        }


        /*alternative method to WriteMessage using integers as arguments to set the newline character ("\n")
        public static void WriteMessage(string message, int beginMessage = 0, int endMessage = 0)
        {
            string skipLine01, skipLine02 = string.Empty;
            

            for (int i = 0; i < beginMessage; i++)
            {
                skipLine01 = skipLine01 + "\n";
            };

            for (int i = 0; i < endMessage; i++)
            {
                skipLine02 = skipLine02 + "\n";
            };

            Console.Write($"{skipLine01}{message}{skipLine02}");
        }

        ex:
        Utility.WriteMessage($"String - nome completo: {nomeCompleto}", 0, 1);
        Utility.WriteMessage($"String - horário: {horario}", 0, 2);

        */

        // Create a method to show a message setted with skip lines at the beginning and end of it
        public static void WriteMessage(string message, string beginMessage = "", string endMessage = "")
        {
            Console.Write($"{beginMessage}{message}{endMessage}");
        }

        // Create a method to terminate the console with a stylish message
        public static void TerminateConsole()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n\nPrime qualquer tecla para terminares.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
        }

        public static void PauseConsole()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n\nPrime qualquer tecla para continuar.\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }

        
    }
}
