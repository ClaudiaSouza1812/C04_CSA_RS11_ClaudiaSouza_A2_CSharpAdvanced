using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_LINQ_linqMethods
{
    internal class LinqMethods
    {
        #region Variáveis da classe

        internal List<TimeSpan> timepanList = new List<TimeSpan>();

        #endregion

        #region Methods

        internal void CreateListTimespan()
        {
            Random random = new Random();

            TimeSpan start = TimeSpan.FromHours(0);
            TimeSpan end = TimeSpan.FromHours(24);

            // Calcular os minutos para servir de cálculo ás horas

            int maxMinutes = (int)(end - start).TotalMinutes;

            for (int i = 0; i < 10; i++)
            {
                int minutes = random.Next(maxMinutes);
                timepanList.Add(start.Add(TimeSpan.FromMinutes(minutes)));
            }
        }

        #endregion
    }
}
