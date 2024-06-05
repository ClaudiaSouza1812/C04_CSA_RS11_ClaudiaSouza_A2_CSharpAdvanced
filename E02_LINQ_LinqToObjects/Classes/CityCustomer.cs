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

        List<City> listCities = new List<City>();
        List<Customer> listCustomers = new List<Customer>();
        IEnumerable listFiltered;

        #endregion

        #region Methods

        #region ListCitiesCustomers

        internal void ListCitiesCustomers()
        {
            foreach (var item in listFiltered)
            {
                Utility.WriteMessage($"{item}", "", "\n");
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
            listFiltered = listCustomers.Where(c => c.Location.Location == "Porto").Select(c => c.Name);

            ListCitiesCustomers();
        }

        #endregion

        #region Consulta 2.2.  O número de clientes da cidade 'Porto'. 

        #endregion

        #region Consulta 2.3.  O cliente mais novo da cidade 'Porto'. 

        #endregion

        #region Consulta 2.4.  O nome dos clientes das cidades 'Lisboa' ou 'Paris'.

        #endregion

        #region Consulta 2.5.  Uma listagem com o formato "nome – idade" das pessoas com mais de 18 anos e ordenada pela idade, descendentemente.

        #endregion

        #region Consulta 2.6.  O nome dos clientes e o país de origem.

        #endregion


        #endregion


    }
}
