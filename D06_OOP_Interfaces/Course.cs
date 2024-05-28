using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06_OOP_Interfaces
{
    // 1º classe a ser feita depois da interface ICourse
    // Classe base, herdeira das interfaces IArea e ICourse
    internal class Course : ICourse, IArea
    {
        #region Properties

        // propriedades herdadas da ICourse:
        public int CourseId { get; set; }

        public string Name { get; set; }

        public int FullCourse { get; set; }

        // propriedades herdadas da IArea:
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
