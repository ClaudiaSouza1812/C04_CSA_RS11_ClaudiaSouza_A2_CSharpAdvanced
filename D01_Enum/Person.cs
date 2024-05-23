using D00_Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Enum
{

    internal class Person
    {
        
        #region Fields (properties, private variables)
        /*
        variáveis internas da classe para serem usadas dentro das propriedades (Classic properties / Bodied-expression properties)
        */
        private string name;

        #endregion

        #region Enums (public or internal) 

        // Enums por dafault são int e zero-based
        internal enum EnumMaritalStatus
        {
            Single,     // 0
            Married,    // 1
            Divorced,   // 2
            Widowed     // 3
        }

        internal enum EnumEyeColor
        {
            Brown = 10,     // 10
            Green = 20,     // 20
            Blue = 5        // 5
        }

        internal enum EnumHairColor
        {
            Brown = 10,     // 0
            Black = 20,     // 1
            White = 5,      // 2
            Blond,           // 3
            Red             // 4
        }

        #endregion

        #region Properties (public or internal)
        #region Auto-implemented properties 2.0
        /* 
        Exemplo de uma propriedade usando Auto-implemented properties
        internal string Operators { get; set; } // Todo MRS: propriedade no singular
        */

        internal int Id { get; }
        internal static int NextId { get; set; } = 1;
        internal EnumMaritalStatus MaritalStatus { get; set; }

        #endregion

        #region Classic properties 1.0
        /* 
        Exemplo de uma propriedade usando Classic properties

        internal double Value01
        {
            get { return value01; }     // Ler o valor da propriedade
            set { value01 = value; }    // escrever o valor da propriedade
        }
        */

        internal string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion

        #region Bodied-expression properties 3.0
        /* 
        Exemplo de uma propriedade usando Bodied-expression properties
        internal double Value02
        {
            get => value02;         // => lambda operator
            set => value02 = value;
        }
        */
        #endregion
        #endregion

        #region Constructors (public or internal)
        // Fazer substituto do default constructor

        internal Person()
        {
            Id = NextId++;
            Name = string.Empty;
        }

        // Fazer segundo construtor com inserção de parâmetros obrigatórios

        internal Person(string name)
        {
            Id = NextId++;
            Name = name;
        }

        internal Person(string name, EnumMaritalStatus maritalStatus)
        {
            Id = NextId++;
            Name = name;
            MaritalStatus = maritalStatus;
        }

        #endregion

        #region Methods (public or internal)

        internal static void ListPerson(List<Person> list)
        {
            Utility.WriteTitle("Person - List", "\n", "\n\n");

            foreach (Person item in list)
            {
                Utility.WriteMessage($"Id: {item.Id}, Name: {item.Name}", "", "\n");
            }
        }

        internal static void AddPerson(List<Person> listPerson)
        {
            Console.Clear();
            Utility.WriteTitle("Add a Person", "\n", "\n\n");

            Utility.WriteMessage("Name: ");

            string name = Console.ReadLine();

            Utility.WriteMessage("Marital status (Single, Married, Divorced, Widowed): ", "", "\n");

            string maritalStatus = Console.ReadLine();

            // Validar se o input é correto de acordo com a enum
            // true: ignora o case do input, aceita 'Single' e 'single'
            if (Enum.TryParse(maritalStatus, true, out EnumMaritalStatus status))
            {
                Person person = new Person(name, status);
                listPerson.Add(person);
                Utility.WriteMessage($"Person '{person.Name}' inserted successfully with ID '{person.Id}' and marital status {person.MaritalStatus}");
            }
            else
            {
                Utility.WriteMessage("Invalid marital status entered.", "\n\n");
            }
        }

        
        #endregion

        #region Destructor

        #endregion
    }
}
