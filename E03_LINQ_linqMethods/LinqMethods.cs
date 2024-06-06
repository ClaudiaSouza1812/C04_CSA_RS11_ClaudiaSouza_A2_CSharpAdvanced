using D00_Utility;
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
        #region Fields (Variáveis da classe)

        internal List<TimeSpan> timepanList = new List<TimeSpan>();

        #endregion

        #region CitiesCustomersMethodSyntax

        internal void CitiesCustomersMethodSyntax()
        {
            CreateListTimespan();

            Utility.WriteTitle("MethodAndQuerySyntax - Cities and Customers", "", "\n\n");
            FindAllTimespans();

        }

        #endregion

        #region Methods

        #region Listar timespans

        internal void ListTimespans()
        {
            CreateListTimespan();

            Utility.WriteTitle("Lista de timespans", "", "\n\n");

            foreach (var item in timepanList)
            {
                Utility.WriteMessage(item.ToString(), "\n");
            }
        }

        #endregion

        #region 1.1.  Criar uma timespan de números aleatórios entre 0 e 24 horas.

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

        #region 1.2.  Usar  FindAll()  para  localizar  todas  as  timespans  inferiores  a  12 horas.

        // var timesList = timepanList.FindAll(t => t < new TimeSpan(12, 0, 0));

        internal void FindAllTimespans()
        {
            var timesList = timepanList.FindAll(t => t.Hours < 12);

            Utility.WriteTitle("Usar  FindAll()  para  localizar  todas  as  timespans  inferiores  a  12 horas.", "", "\n\n");

            foreach (var item in timesList)
            {
                Utility.WriteMessage(item.ToString(), "", "\n");
            };

            ListTimespans();
        }

        #endregion


        #endregion



        

        
    }
}
