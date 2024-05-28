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

    internal class Course : ICourse, IArea
    {
        #region Properties

        // propriedades herdadas da ICourse (comuns á todas as futuras classes):
        public int CourseId { get; set; }

        public string Name { get; set; }

        public int FullCourse { get; set; }

        // propriedades herdadas da IArea (comuns á todas as futuras classes):
        public int AreaId { get; set; }

        public string AreaName { get; set; }

        public string SubareaName { get; set; }

        public string Description { get; set; }


        #region Constructors (public or internal)

        public Course() 
        { 
            
        }

        #endregion

        #endregion

        #region Methods
        // métodos herdados da ICourse (comuns á todas as futuras classes)
        // dosi métodos ListCourse com duas assinaturas diferentes

        public void ListCourse(string level)
        {
            throw new NotImplementedException();
        }

        public void ListCourse(DateTime timestamp)
        {
            throw new NotImplementedException();
        }

        public void ReadCourse()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
