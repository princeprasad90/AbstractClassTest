using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    class ContractEmployee : BaseClass
    {
        public override int CalCulateMonthlySalary()
        {
            return Hour_Salary * TotalHoursWorked;
        }
    }
}
