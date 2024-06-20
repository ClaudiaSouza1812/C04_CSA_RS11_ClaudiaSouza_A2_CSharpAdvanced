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

            Utility.WriteTitle("Method And Query Syntax - Cities and Customers", "", "\n\n");

            ListTimespans(timespanList);

            FindAllTimespansMethodSintax();

            ExistNumberMethodSintax();

            Between0and24MethodSintax();

            ReturnHourMethodSintax();

            FindAllTimespansQuerySintax();

            ExistNumberQuerySintax();

            Between0and24QuerySintax();

            ReturnHourQuerySintax();

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

            timespanList = Enumerable.Range(0, 10).Select(_ => start.Add(TimeSpan.FromMinutes(random.Next(maxMinutes)))).ToList();

            /*
            for (int i = 0; i < 10; i++)
            {
                int minutes = random.Next(maxMinutes);
                timespanList.Add(start.Add(TimeSpan.FromMinutes(minutes)));
            }
            */
        }

        #endregion

        #region 1.2.  Usar  FindAll()  para  localizar  todas  as  timespans  inferiores  a  12 horas.

        #region Method sintax

        // var timesList = timepanList.FindAll(t => t < new TimeSpan(12, 0, 0));

        internal void FindAllTimespansMethodSintax()
        {
            Utility.WriteTitle("Usar  FindAll()  para  localizar  todas  as  timespans  inferiores  a  12 horas - MethodSintax", "", "\n\n");

            var timesList = timespanList.FindAll(t => t.Hours < 12);

            ListTimespans(timesList);

        }

        #endregion

        #region Query sintax

        internal void FindAllTimespansQuerySintax()
        {
            Utility.WriteTitle("Localizar  todas  as  timespans  inferiores  a  12 horas - QuerySintax", "", "\n\n");

            var timeList =
                from t in timespanList
                where t.Hours < 12
                select t;

            ListTimespans(timeList);
        }
        #endregion

        #endregion

        #region 1.3.  Usar Exists() para verificar se alguma timespan tiver 5 na propriedade Hours.

        #region Method sintax

        internal void ExistNumberMethodSintax()
        {
            Utility.WriteTitle("Usar Exists() para verificar se alguma timespan tiver 5 na propriedade Hours - MethodSintax", "\n", "\n\n");

            var exist = timespanList.Exists(t => t.Hours == 5);

            if (exist)
            {
                Utility.WriteMessage("As timespans com '5' na hora são:", "", "\n");

                var timeList = timespanList.FindAll(t => t.Hours == 5);

                ListTimespans(timeList);
            }
            else
            {
                Utility.WriteMessage("Não existem timespans com '5' na hora.");
            }
        }
        #endregion

        #region Query sintax

        internal void ExistNumberQuerySintax()
        {
            Utility.WriteTitle("Verificar se alguma timespan tiver 5 na propriedade Hours - QuerySintax", "\n", "\n\n");

            var timeList =
                from t in timespanList
                where t.Hours == 5
                select t;

            if (timeList.Any())
            {
                Utility.WriteMessage("As timespans com '5' na hora são:", "", "\n");

                ListTimespans(timeList);
            }
            else
            {
                Utility.WriteMessage("Não existem timespans com '5' na hora.");
            }
        }

        #endregion

        #endregion

        #region 1.4. Usar TrueForAll() para garantir que todas as timespans estão entre 0 e 24 horas.

        #region Method sintax

        internal void Between0and24MethodSintax()
        {
            Utility.WriteTitle("Usar TrueForAll() para garantir que todas as timespans estão entre 0 e 24 horas - MethodSintax", "\n", "\n\n");

            var isAllTrue = timespanList.TrueForAll(t => t.Hours >= 0 && t.Hours <= 24);

            if (!isAllTrue)
            {
                Utility.WriteMessage("As timespans fora do range entre 0 e 24 horas são:", "", "\n");

                var timeList = timespanList.Where(t => t.Hours < 0 || t.Hours > 24).ToList();

                ListTimespans(timeList);
            }
            else
            {
                Utility.WriteMessage("Todas as horas dentro do range entre 0 e 24 horas");
            }
        }
        #endregion

        #region Query sintax

        internal void Between0and24QuerySintax()
        {
            Utility.WriteTitle("Garantir que todas as timespans estão entre 0 e 24 horas - QuerySintax", "\n", "\n\n");

            var timeList =
                from t in timespanList
                where t.TotalHours < 0 || t.TotalHours > 24
                select t;

            if (timeList.Any())
            {
                Utility.WriteMessage("As timespans fora do range entre 0 e 24 horas são:", "", "\n");

                ListTimespans(timeList);
            }
            else
            {
                Utility.WriteMessage("Todas as horas dentro do range entre 0 e 24 horas");
            }
        }
        #endregion

        #endregion

        #region 1.5. Usar  ConvertAll()  para  retornar  só  a  parte  de  Hours  de  cada timespan.

        #region Method sintax

        internal void ReturnHourMethodSintax()
        {
            Utility.WriteTitle("Usar  ConvertAll()  para  retornar  só  a  parte  de  Hours  de  cada timespan - MethodSintax", "\n", "\n\n");

            var timeList = timespanList.ConvertAll(t => t.Hours);

            ListTimespans(timeList);
        }
        #endregion

        #region Query sintax

        internal void ReturnHourQuerySintax()
        {
            Utility.WriteTitle("Retornar  só  a  parte  de  Hours  de  cada timespan - QuerySintax", "\n", "\n\n");

            var timeList =
                from t in timespanList
                select t.Hours;

            ListTimespans(timeList);
        }

        #endregion

        #endregion

        #region Listar timespans

        internal void ListTimespans(IEnumerable<TimeSpan> timespanList)
        {
            Utility.WriteTitle("Lista de timespans", "", "\n");

            foreach (var item in timespanList)
            {
                Utility.WriteMessage(item.ToString(), "", "\n");
            }
        }

        internal void ListTimespans(IEnumerable<int> timespanList)
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
