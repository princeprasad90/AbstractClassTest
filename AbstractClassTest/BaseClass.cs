using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    class BaseClass
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Day_Salary { get; set; }
        public int Hour_Salary { get; set; }
        public int TotalHoursWorked { get; set; }
        public virtual string DisplayName_Gender()
        {
            return Name + "  " + Gender;
        }
        public virtual int CalCulateMonthlySalary()
        {
            throw new NotImplementedException();
        }
    }
   
}
