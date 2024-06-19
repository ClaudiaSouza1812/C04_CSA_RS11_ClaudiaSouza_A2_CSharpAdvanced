using D00_Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace E04_ExtensionMethod
{

    internal class Person
    {
        
        #region Fields (properties, private variables)
        /*
        variáveis internas da classe para serem usadas dentro das propriedades (Classic properties / Bodied-expression properties)
        */
        private string firstName;
        private string lastName;
        private string age;

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
        internal EnumEyeColor EyeColor { get; set; }
        internal EnumHairColor HairColor { get; set; }

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

        internal string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
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

        internal string Age
        {
            get => age;
            set => age = value;
        }

        internal string LastName
        {
            get => lastName;
            set => lastName = value;
        }
        #endregion
        #endregion

        #region Constructors (public or internal)

        // Construtor substituto do default constructor

        internal Person()
        {
            Id = NextId++;
            FirstName = string.Empty;
            LastName = string.Empty;
            Age = string.Empty;
            MaritalStatus = EnumMaritalStatus.Single;
            EyeColor = EnumEyeColor.Brown;
            HairColor = EnumHairColor.Brown;
        }

        // Segundo construtor com inserção de parâmetros obrigatórios

        internal Person(string firstName, string lastName, string age, EnumMaritalStatus maritalStatus, EnumEyeColor eyeColor, EnumHairColor hairColor)
        {
            Id = NextId++;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            MaritalStatus = maritalStatus;  
            EyeColor = eyeColor;
            HairColor = hairColor;
        }

        // Terceiro construtor com inserção de parâmetros obrigatórios

        internal Person(string firstName, EnumMaritalStatus maritalStatus)
        {
            Id = NextId++;
            FirstName = firstName;
            MaritalStatus = maritalStatus;
        }

        #endregion

        // O método Deconstruct é um método especial que permite desestruturar um objeto em variáveis individuais.
        #region Deconstructor Method

        // 4. Deconstruct - Implementar o método Deconstruct na classe Person para permitir a desestruturação de objetos Person.

        internal void Deconstruct(out string firstName, out string lastName, out string age, out EnumMaritalStatus maritalStatus, out EnumEyeColor eyeColor, out EnumHairColor hairColor)
        {
            firstName = FirstName;
            lastName = LastName;
            age = Age;
            maritalStatus = MaritalStatus;
            eyeColor = EyeColor;    
            hairColor = HairColor;
        }

        #endregion

        #region Methods (public or internal)

        //
        internal static void AddPerson(List<Person> listPerson)
        {

            (string, EnumMaritalStatus) personInformation = GetPersonInformation();

            Person person = new Person(personInformation.Item1, personInformation.Item2);

            listPerson.Add(person);

            ShowMessage(true, person);
            
        }

        internal static (string, EnumMaritalStatus) GetPersonInformation()
        {
            Utility.WriteTitle("Enter the Person information", "\n", "\n\n");

            Utility.WriteMessage("Name: ");
            string name = Console.ReadLine();

            Utility.WriteMessage("Marital status (Single, Married, Divorced, Widowed): ");
            string maritalStatus = Console.ReadLine();

            (bool, EnumMaritalStatus) isMaritalStatus = ValidateMaritalStatus(maritalStatus);

            if (isMaritalStatus.Item1)
            {
                return (name, isMaritalStatus.Item2);

            }
            else
            {
                ShowMessage(false, null);
                return (name, EnumMaritalStatus.Single);
            }
            
        }
        
        //
        internal static (bool, EnumMaritalStatus) ValidateMaritalStatus(string maritalStatus)
        {
            // Validar se o input é correto de acordo com a enum
            // true: ignora o case do input, aceita 'Single' e 'single'
            bool isValid = Enum.TryParse(maritalStatus, true, out EnumMaritalStatus status);

            return (isValid, status);
        }
        //
        internal static void ShowMessage(bool status, Person person)
        { 
            if (status)
            {
                Utility.WriteMessage($"Person '{person.FirstName}' inserted successfully with ID '{person.Id}' and marital status '{person.MaritalStatus}'.");
            }
            else
            {
                Utility.WriteMessage("\"Invalid marital status entered, default value 'Single' will be set.", "\n\n");
            }
        }
        //
        internal static void ListPerson(List<Person> list)
        {
            Utility.WriteTitle("Person - List", "\n", "\n\n");

            foreach (Person item in list)
            {
                Utility.WriteMessage($"Id: {item.Id}, Name: {item.FirstName}", "", "\n");
            }
        }

        #endregion

        #region Destructor

        #endregion
    }
}
