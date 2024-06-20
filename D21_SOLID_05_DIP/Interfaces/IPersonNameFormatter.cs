/*
    SOLID
    DIP
    Dependency Inversion Principle (DIP)
    As classes devem depender de abstrações, não de classes concretas
    Exemplo: criar a classe PersonService que depende de interfaces para realizar operações
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_SOLID_05_DIP
{
    internal interface IPersonNameFormatter
    {
        string FormatName(Person person);
    }
}
