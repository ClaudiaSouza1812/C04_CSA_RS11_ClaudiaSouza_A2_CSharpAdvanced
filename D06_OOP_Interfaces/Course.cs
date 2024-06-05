using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06_OOP_Interfaces
{
    // 1º classe a ser feita depois de criar as interfaces ICourse e IArea
    // Vai implementar o que foi declarado na ICourse e IArea
    // Classe base, herda propriedades e métodos das interfaces IArea e ICourse
    // Só são herdados itens que serão replicados as demais classes
    // Itens que são exclusivos de determinadas classes, não devem ser herdados, pois não serã usados nas demais classes

    internal abstract class Course : ICourse, IArea
    {
        #region Properties

        #region Auto-implemented properties 2.0

        // implanta as propriedades herdadas da ICourse (comuns á todas as futuras classes):
        public int CourseId { get; set; }

        public string Name { get; set; }

        // implanta as propriedades herdadas da IArea (comuns á todas as futuras classes):
        public int AreaId { get; set; }

        public string AreaName { get; set; }

        public string SubareaName { get; set; }

        public string Description { get; set; }

        #region Classic properties 1.0 (use field)
        /* 
        Exemplo de uma propriedade usando Classic properties

        internal double Value01
        {
            get { return value01; }     // Ler o valor da propriedade
            set { value01 = value; }    // escrever o valor da propriedade
        }
        */

        #endregion

        #region Bodied-expression properties 3.0 (use field)
        /* 
        Exemplo de uma propriedade usando Bodied-expression properties
        internal double Value02
        {
            get => value02;         // => lambda operator
            set => value02 = value;
        }
        */

        #endregion

        #region Bodied-expression - lambda expression
        /* 
        a lambda expression to define a read-only property in a concise manner, ex:
        
        internal string FullCourse => $"Course nº {CourseId}: {Area} - {Name}"; // Get
        internal string FullCourse => field = value;     // Set
        */

        // virtual: indica que a propriedade poderá ser reescrita (override) na derived (inherited) classe
        public virtual string FullCourse => $"Course nº {CourseId}: {Name} - {AreaName} - {SubareaName} - {Description}"; // Get

        // internal string FullCourse => field = value;     // Set

        #endregion

        #endregion

        #region Constructors (public or internal)

        public Course() 
        { 
            CourseId = 0;
            AreaId = 0;
            Name = string.Empty;
            AreaName = string.Empty;
            SubareaName = string.Empty;
            Description = string.Empty;
        }

        public Course(int courseId, int areaId, string name, string areaName, string subareaName, string description)
        {
            CourseId= courseId;
            AreaId= areaId; 
            Name= name;
            AreaName= areaName;
            SubareaName= subareaName;
            Description = description;
        }

        #endregion

        #endregion

        #region Methods
        // implanta as métodos herdados da ICourse (comuns á todas as futuras classes)
        // dois métodos ListCourse com duas assinaturas diferentes

        public virtual void ReadCourse()
        {
            #region CorseId

            bool converted = false;
            int value = 0;

            Utility.WriteMessage("Course id: ");

            converted = int.TryParse(Console.ReadLine(), out value);

            if (converted)
            {
                CourseId = value;
            }

            #endregion

            #region CourseName

            Utility.WriteMessage("Course name: ");
            Name = Console.ReadLine();

            #endregion

            #region Area

            Utility.WriteMessage("Course area: ");
            AreaName = Console.ReadLine();

            #endregion

            #region Subarea

            Utility.WriteMessage("Course subarea: ");
            SubareaName = Console.ReadLine();

            #endregion

            #region Description

            Utility.WriteMessage("Course Description: ");
            Description = Console.ReadLine();

            #endregion
        }

        public virtual void ListCourse()
        {
            Utility.WriteMessage(FullCourse, "\n\n");
        }

        public virtual void ListCourse(string level)
        {
            Utility.WriteMessage($"{FullCourse} ({level}), ", "\n\n");
        }

        public virtual void ListCourse(DateTime timestamp)
        {
            Utility.WriteMessage($"{FullCourse} Starts: ({timestamp.ToShortDateString()}), ", "\n\n");
        }

        // An abstract method, must be overridden and implemented in a derived class

        public abstract void Billing(string status);

        #endregion

    }
}
