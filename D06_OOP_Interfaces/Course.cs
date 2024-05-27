using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06_OOP_Interfaces
{
    internal class Course : IArea, ICourse
    {
        #region Properties

        public int AreaId { get; set; }

        public string AreaName { get; set; }

        public string SubareaName { get; set; }

        public string Description { get; set; }


        public int CourseId { get; set; }

        public string Name { get; set; }

        public int FullCourse { get; set; }



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
