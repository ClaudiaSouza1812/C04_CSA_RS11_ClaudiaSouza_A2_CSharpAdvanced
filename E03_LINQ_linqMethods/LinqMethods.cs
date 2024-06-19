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

        internal List<TimeSpan> timespanList = new List<TimeSpan>();

        #endregion

        #region CitiesCustomersMethodSyntax

        internal void CitiesCustomersMethodSyntax()
        {
            CreateListTimespan();

            Utility.WriteTitle("MethodAndQuerySyntax - Cities and Customers", "", "\n\n");

            FindAllTimespans();

            ListTimespans();

            ExistNumber();

            Between0and24();

            ReturnHour();

        }

        #endregion

        #region Methods

        

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
                timespanList.Add(start.Add(TimeSpan.FromMinutes(minutes)));
            }
        }

        #endregion

        #region 1.2.  Usar  FindAll()  para  localizar  todas  as  timespans  inferiores  a  12 horas.

        // var timesList = timepanList.FindAll(t => t < new TimeSpan(12, 0, 0));

        internal void FindAllTimespans()
        {
            Utility.WriteTitle("Usar  FindAll()  para  localizar  todas  as  timespans  inferiores  a  12 horas.", "", "\n\n");

            var timesList = timespanList.FindAll(t => t.Hours < 12);

            foreach (var item in timesList)
            {
                Utility.WriteMessage(item.ToString(), "", "\n");
            };

        }

        #endregion

        #region 1.3.  Usar Exists() para verificar se alguma timespan tiver 5 na propriedade Hours.


        internal void ExistNumber()
        {
            Utility.WriteTitle("Usar Exists() para verificar se alguma timespan tiver 5 na propriedade Hours.", "\n", "\n\n");

            var exist = timespanList.Exists(t => t.Hours == 5);

            if (exist)
            {
                Utility.WriteMessage("As timespans com '5' na hora são:", "", "\n");

                var timeList = timespanList.FindAll(t => t.Hours == 5);

                foreach (TimeSpan time in timeList)
                {
                    Utility.WriteMessage(time.ToString(), "", "\n");
                }            
            }
            else
            {
                Utility.WriteMessage("Não existem timespans com '5' na hora.");
            }
        }

        #endregion

        #region 1.4. Usar TrueForAll() para garantir que todas as timespans estão entre 0 e 24 horas.


        internal void Between0and24()
        {
            Utility.WriteTitle("Usar TrueForAll() para garantir que todas as timespans estão entre 0 e 24 horas.", "\n", "\n\n");

            var isAllTrue = timespanList.TrueForAll(t => t.Hours >= 0 && t.Hours <= 24);

            if (!isAllTrue) 
            {
                Utility.WriteMessage("As timespans fora do range entre 0 e 24 horas são:", "", "\n");

                var timeList = timespanList.Where(t => t.Hours < 0 || t.Hours > 24).ToList();

                foreach (TimeSpan time in timeList)
                {
                    Utility.WriteMessage(time.ToString(), "", "\n");
                }
            }
            else
            {
                Utility.WriteMessage("Todas as horas dentro do range entre 0 e 24 horas");
            }
        }

        #endregion

        #region 1.5. Usar  ConvertAll()  para  retornar  só  a  parte  de  Hours  de  cada timespan.

        internal void ReturnHour()
        {
            Utility.WriteTitle("Usar  ConvertAll()  para  retornar  só  a  parte  de  Hours  de  cada timespan.", "\n", "\n\n");

            var timeList = timespanList.ConvertAll(t => t.Hours);

            foreach (int time in timeList)
            {
                Utility.WriteMessage(time.ToString(), "", "\n");
            }
        }

        #endregion

        #region Listar timespans

        internal void ListTimespans()
        {
            Utility.WriteTitle("Lista de timespans", "", "\n");

            foreach (var item in timespanList)
            {
                Utility.WriteMessage(item.ToString(), "", "\n");
            }
        }

        #endregion

        #endregion






    }
}
