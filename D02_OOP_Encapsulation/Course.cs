using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_OOP_Encapsulation
{
    internal class Course
    {
        
        #region Enums


        #endregion
        #region Fields (properties, private variables)
        /*
        variáveis internas da classe para serem usadas dentro das propriedades (Classic properties / Bodied-expression properties)
        */

        private string name;
        private string area;

        #endregion

        #region Enums (public or internal) 

        /* Enums por dafault são int e zero-based
        internal enum EnumMaritalStatus
        {
            Single,     // 0
            Married,    // 1
            Divorced,   // 2
            Widowed     // 3
        }
        */


        #endregion

        #region Properties (public or internal)
        #region Auto-implemented properties 2.0
        /* 
        Exemplo de uma propriedade usando Auto-implemented properties
        internal string Operators { get; set; } // Todo MRS: propriedade no singular
        */

        internal int CourseId { get; set; }

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

        internal string Name
        {
            get { return name; }
            set { name = value.ToUpper(); }
        }
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

        internal string Area
        {
            get => area;
            set => area = value.ToUpper();
        }

        internal string FullCourse => $"Course nº {CourseId}: {Area} - {Name}"; // Get
        // internal string FullCourse => field = value;     // Set

        #endregion
        #endregion

        #region Constructors (public or internal)
        // Fazer substituto do default constructor




        // Fazer segundo construtor com inserção de parâmetros obrigatórios



        #endregion

        #region Methods (public or internal)

        internal void ReadCourse()
        {
            #region CorseID

            bool converted;
            int value;

            Utility.WriteMessage("Course id: ", "\n\n");

            bool converted = int.TryParse(Console.ReadLine(), out value);

            if (converted) 
            {
                CourseId = value;
            }

            #endregion

            #region CourseName

            Utility.WriteMessage("Course name: ", "\n\n");
            Name = Console.ReadLine();

            #endregion

            #region Area

            Utility.WriteMessage("Course area: ", "\n\n");
            Area = Console.ReadLine();

            #endregion
        }


        internal void ListCourse()
        {
            Utility.WriteMessage(FullCourse, "\n\n");
        }


        #endregion

        #region Destructor

        #endregion
        
    }
}
