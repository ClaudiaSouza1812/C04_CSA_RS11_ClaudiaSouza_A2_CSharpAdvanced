using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_ClassTemplate_v01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Fields (properties, private variables)
            /*
            variáveis internas da classe para serem usadas dentro das propriedades (Classic properties / Bodied-expression properties)
            */

            #endregion

            #region Properties (public or internal)
            #region Auto-implemented properties 2.0
            /* 
            Exemplo de uma propriedade usando Auto-implemented properties
            internal string Operators { get; set; } // Todo MRS: propriedade no singular
            */

            #endregion

            #region Classic properties 1.0
            /* 
            Exemplo de uma propriedade usando Classic properties

            internal double Value01
            {
                get { return value01; }     // Ler o valor da propriedade
                set { value01 = value; }    // escrever o valor da propriedade
            }
            */

            #endregion

            #region Bodied-expression properties 3.0
            /* 
            Exemplo de uma propriedade usando Bodied-expression properties
            internal double Value02
            {
                get => value02;         // => lambda operator
                set => value02 = value;
            }
            */

            #endregion
            #endregion

            #region Constructors (Public)
            // Fazer substituto do default constructor


            // Fazer segundo construtor com inserção parâmetros obrigatórios

            #endregion

            #region Methods (public or internal)

            #endregion

            #region Destructor

            #endregion
        }
    }
}
