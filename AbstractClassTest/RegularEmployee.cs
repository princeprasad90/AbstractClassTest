using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    class RegularEmployee : BaseClass
    {
        public override int CalCulateMonthlySalary()
        {
            return Day_Salary * 30;
        }
    }
}
