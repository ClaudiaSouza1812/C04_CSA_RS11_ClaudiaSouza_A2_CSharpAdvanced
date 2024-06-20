using D21_SOLID_05_DIP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_SOLID_05_DIP
{
    internal interface IEmployeeRepository
    {
        void AddEmployee(Employee employee);

        Employee GetEmployee(int employeeId);
    }
}
