﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_ClassTemplate_v01
{
    internal class Program
    {

        /*
        CLASS ELEMENTS:
            Attributes or fields    = variáveis privadas da classe (suporte às propriedades)
            Properties              = caraterísticas
            Methods                 = funcionalidades
            Constructors            = funcionalidade invocada aquando da criação do objeto
            Destructor              = funcionalidade que permite indicar como é que o objeto é destruído
        EXEMPLO
            Classe: Produto
            Objects (instâncias da classe): Produto1, Produto2, Produto3...
            Properties: Nome, Cor, Unidade, ...
            Methods: Inserir, Pesquisar, Editar, Apagar, ...
            Constructor: Cor = verde
            Destructor (log): informar que o objeto vai ser destruído

        */

        /*
            Propriedades: 
                CourseId
                Name (tem de ser em maiúsculas)
                Area (tem de ser em maiúsculas)
                FullCourse (read-only - get)

            Métodos void:
                ReadCourse
                ListCourse
        */

        #region Enums (public or internal) 

        /* Enums por default são int e zero-based, ex:
        internal enum EnumMaritalStatus
        {
            Single,     // 0
            Married,    // 1
            Divorced,   // 2
            Widowed     // 3
        }
        */

        #endregion

        #region Fields (properties, private variables)

        /*
        variáveis internas da classe para serem usadas dentro das propriedades (Classic properties / Bodied-expression properties), ex:
        private string name;
        */

        #endregion

        #region Properties (public or internal)

        #region Auto-implemented properties 2.0
        /* 
        Exemplo de uma propriedade usando Auto-implemented properties
        internal string Operators { get; set; } // Todo MRS: propriedade no singular
        */

        #endregion

        #region Classic properties 1.0 (use field)

        /* 
        Exemplo de uma propriedade usando Classic properties

        internal double Value01
        {
            get { return value01; }     // Ler o valor da propriedade
            set { value01 = value; }    // escrever o valor da propriedade
        }
        */

        #endregion

        #region Bodied-expression properties 3.0 (use field)

        #region Bodied-expression - classic declaration
        /* 
        Exemplo de uma propriedade usando Bodied-expression properties
        internal double Value02
        {
            get => value02;         // => lambda operator
            set => value02 = value;
        }
        */


        #endregion

        #region Bodied-expression - lambda expression

        /* a lambda expression to define a read-only property in a concise manner, ex:

        internal string FullCourse => $"Course nº {CourseId}: {Area} - {Name}"; // Get
        internal string FullCourse => field = value;     // Set
        */


        #endregion

        #endregion

        #endregion

        #region Constructors (public or internal)
        /* Substituto do default constructor, ex:
        internal Person()
        {
            Id = NextId++;
            Name = string.Empty;
        }
        */


        /* Segundo construtor com inserção de parâmetros obrigatórios, ex:
        internal Person(string name, EnumMaritalStatus maritalStatus)
        {
            Id = NextId++;
            Name = name;
            MaritalStatus = maritalStatus;
        }
        */



        #endregion

        #region Methods (public or internal)


        #endregion

        #region Destructor

        #endregion
    }

}