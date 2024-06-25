using D21_SOLID_05_DIP_V1.Classes;
using D21_SOLID_05_DIP_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D21_SOLID_05_DIP_V1_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region Person

            // Repositories
            IPersonRepository personRepository = new PersonRepository();
            INameFormatter personNameFormatter = new NameFormatter();
            PersonService personService = new PersonService(personRepository, personNameFormatter);

            // Add person
            Person person = new Person("Milena", "Reis e Sousa", 56);
            personService.AddPerson(person);

            // Get person formatted name
            Utility.WriteTitle("Person name Formatted", "", "\n");

            string formattedName = personService.GetFormattedName("Milena", "Reis e Sousa");
            Utility.WriteMessage($"Formatted name: {formattedName}", "", "\n");

            #endregion

            #region Employee

            // Repositories
            IEmployeeRepository employeeRepository = new EmployeeRepository();
            INameFormatter employeeNameFormatter = new NameFormatter();
            EmployeeService employeeService = new EmployeeService(employeeRepository, employeeNameFormatter);

            // Add employee
            Employee employee = new Employee("Claudia", "Souza", 31);
            employeeService.AddEmployee(employee);

            // Get employee formatted name
            Utility.WriteTitle("Employee name Formatted", "", "\n");

            string employeeFormattedName = employeeService.GetEmployeeFormattedName(employee.EmployeeID);

            Utility.WriteMessage($"Formatted employee name: {employeeFormattedName}", "", "\n");

            #endregion


            Utility.TerminateConsole();
        }
    }
}
