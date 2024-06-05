using D00_Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_LINQ_LinqToObjects.Classes
{
    internal class CityCustomer
    {
        #region Variáveis da classe

        internal List<City> listCities = new List<City>();
        internal List<Customer> listCustomers = new List<Customer>();
        internal IEnumerable filteredList;

        #endregion

        #region Methods

        #region CitiesCustomersMethodSyntax

        internal void CitiesCustomersMethodSyntax()
        {
            CreateCitiesCustomers();

            Utility.WriteTitle("MethodSyntax - Cities and Customers", "", "\n\n");
            MethodSyntaxQuestion1();
            MethodSyntaxQuestion2();
            MethodSyntaxQuestion3();
            MethodSyntaxQuestion4();
            MethodSyntaxQuestion5();
            MethodSyntaxQuestion6();
            MethodSyntaxQuestion6v2();

        }

        #endregion

        #region ListCitiesCustomers

        internal void ListCitiesCustomers()
        {
            foreach (var item in filteredList)
            {
                Utility.WriteMessage($"\t{item}", "", "\n");
            }
        }

        #endregion

        #region CreateCitiesCustomers

        internal void CreateCitiesCustomers()
        {
            #region 1. Adicionar Cities

            // 1. Adicionar cities
            // v0. Criando variáveis na memória
            /*
            City city01 = new City();
            city01.Location = "Porto";
            city01.Country = "Portugal";
            listCities.Add(city01);
            */

            // v1: versão mais rápida disto:
            listCities.Add(new City { Location = "Porto", Country = "Portugal" });
            listCities.Add(new City { Location = "Londres", Country = "Inglaterra" });
            listCities.Add(new City { Location = "Paris", Country = "França" });
            listCities.Add(new City { Location = "Lisboa", Country = "Portugal" });

            // v2: desafio: versão mais rápida da versão 1

            #endregion

            #region 2. Adicionar customers (com ligação a cities)

            listCustomers.Add(new Customer { Name = "Amália", Location = listCities.FirstOrDefault(l => l.Location == "Porto"), Age = 35 });
            listCustomers.Add(new Customer { Name = "John", Location = listCities.FirstOrDefault(l => l.Location == "Londres"), Age = 35 });
            listCustomers.Add(new Customer { Name = "Carlos", Location = listCities.FirstOrDefault(l => l.Location == "Porto"), Age = 53 });
            listCustomers.Add(new Customer { Name = "Lucy", Location = listCities.FirstOrDefault(l => l.Location == "Paris"), Age = 21 });
            listCustomers.Add(new Customer { Name = "Xavier", Location = listCities.FirstOrDefault(l => l.Location == "Lisboa"), Age = 14 });
            #endregion
        }

        #endregion


        #region Consulta 2.1.  O nome dos clientes da cidade 'Porto'. 
        internal void MethodSyntaxQuestion1()
        {
            Utility.WriteMessage("2.1. O nome dos clientes da cidade 'Porto'.", "", "\n");
            filteredList = listCustomers.Where(c => c.Location.Location == "Porto").Select(c => c.Name);

            ListCitiesCustomers();
        }

        #endregion

        #region Consulta 2.2.  O número de clientes da cidade 'Porto'. 

        internal void MethodSyntaxQuestion2()
        {
            Utility.WriteMessage("2.2. O número de clientes da cidade 'Porto'.", "", "\n");
            int cityCount = listCustomers.Where(c => c.Location.Location == "Porto").Count();

            Utility.WriteMessage($"\t{cityCount}", "", "\n");
        }

        #endregion

        #region Consulta 2.3. O cliente mais novo da cidade 'Porto'. 

        internal void MethodSyntaxQuestion3()
        {
            Utility.WriteMessage("2.3. O cliente mais novo da cidade 'Porto'.", "", "\n");

            filteredList = listCustomers.Where(c => c.Location.Location == "Porto").OrderBy(c => c.Age).Take(1).Select(c => c.Name);

            ListCitiesCustomers();
        }

        #endregion

        #region Consulta 2.4.  O nome dos clientes das cidades 'Lisboa' ou 'Paris'.

        internal void MethodSyntaxQuestion4()
        {
            Utility.WriteMessage("2.4. O nome dos clientes das cidades 'Lisboa' ou 'Paris'.", "", "\n");

            filteredList = listCustomers.Where(c => c.Location.Location == "Lisboa" || c.Location.Location == "Paris").Select(c => c.Name);

            ListCitiesCustomers();
        }

        #endregion

        #region Consulta 2.5.  Uma listagem com o formato "nome – idade" das pessoas com mais de 18 anos e ordenada pela idade, descendentemente.

        internal void MethodSyntaxQuestion5()
        {
            filteredList = listCustomers.Where(c => c.Age > 18).OrderByDescending(c => c.Age).Select(c => $"{c.Name} - {c.Age}");

            Utility.WriteMessage("2.5. Uma listagem com o formato \"nome – idade\" das pessoas com mais de 18 anos e ordenada pela idade, descendentemente.", "", "\n");

            ListCitiesCustomers();
        }
        #endregion

        #region Consulta 2.6. O nome dos clientes e o país de origem.

        internal void MethodSyntaxQuestion6()
        {
            Utility.WriteMessage("2.6. O nome dos clientes e o país de origem.", "", "\n");

            filteredList = listCustomers.OrderBy(c => c.Name).Select(c => $"{c.Name} - {c.Location.Country}");

            ListCitiesCustomers();
        }


        internal void MethodSyntaxQuestion6v2()
        {
            Utility.WriteMessage("2.6. O nome dos clientes e o país de origem.", "", "\n");

            filteredList = listCustomers.OrderBy(c => c.Location.Country).ThenBy(c => c.Name).Select(c => $"{c.Location.Country} - {c.Name}");

            ListCitiesCustomers();
        }
        #endregion


        #endregion


    }
}
