using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Filtrar palavras com comprimento de 5 carateres
namespace D09_LINQ
{
    internal class D01_HelloWorld
    {
        #region Method syntax

        internal static void HelloWorldMethodSyntax()
        {
            string[] words =
            {
                "t-sql",
                "hello",
                "wonderful",
                "linq",
                "beautiful",
                "world"
            };

            #region v1. difered execution 

            // NOT OK: string[] shortWords01 = words.Where(w => w.Length == 5); // data.operator(result => expression)
            // NOT OK: List<string> shortWords01 = words.Where(w => w.Length == 5); // data.operator(result => expression)

            // OK: var shortWords01 = words.Where(w => w.Length == 5); // data.operator(result => expression)
            // OK: List<string> shortWords01 = (List<string>)words.Where(w => w.Length == 5); // data.operator(result => expression)
            // OK: System.Collections.Generic.IEnumerable<string> shortWords01 = words.Where(w => w.Length == 5);


            IEnumerable<string> shortWords01 = words.Where(w => w.Length == 5);

            #endregion

            #region v2. real time execution

            var shortWords02 = words.Where(w => w.Length == 5).Select(w => w.ToUpper());

            #endregion

            #region Listar

            Utility.WriteTitle("Hello World - Method Syntax - v1: execução diferida", "", "\n");

            foreach (var item in shortWords01)
            {
                Utility.WriteMessage(item.ToUpper(),"", "\n");
            }

            Utility.WriteTitle("Hello World - Method Syntax - v2: execução em tempo real", "", "\n");

            foreach (var item in shortWords02)
            {
                Utility.WriteMessage(item, "\n");
            }

            #endregion


        }

        #endregion

        #region Query syntax

        internal static void HelloWorldQuerySyntax() 
        {
            string[] words =
            {
                "t-sql",
                "hello",
                "wonderful",
                "linq",
                "beautiful",
                "world"
            };

            var shortWords03 = 
                from w in words
                where w.Length == 5
                select w;

            Utility.WriteTitle("Hello World - Query Syntax", "\n", "\n");

            foreach (var item in shortWords03)
            {
                Utility.WriteMessage(item.ToUpper(), "", "\n");
            }
        }

        #endregion
    }
}
