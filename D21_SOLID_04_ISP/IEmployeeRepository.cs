using D21_SOLID_04_ISP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D21_SOLID_04_ISP
{
    internal interface IEmployeeRepository
    {
        void AddEmployee(Employee employee);

        Employee GetEmployee(string employeeId);
    }
}
