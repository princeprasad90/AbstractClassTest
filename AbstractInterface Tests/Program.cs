using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            RegularEmployee Reg = new RegularEmployee()
            {
                Name = "Prince",
                Gender = "Male",
                Day_Salary = 2000
            };
            Console.WriteLine(Reg.DisplayName_Gender());
            Console.WriteLine(Reg.CalCulateMonthlySalary());
            Console.WriteLine("----------------------------------");
            ContractEmployee Ctrt = new ContractEmployee()
            {
                Name="Ram",
                Gender="Male",
                Hour_Salary=50,
                TotalHoursWorked=1500,
            };
            Console.WriteLine(Ctrt.DisplayName_Gender());
            Console.WriteLine(Ctrt.CalCulateMonthlySalary());
            Console.WriteLine("----------------------------------");

            #endregion



            #region
            RegularEmployeeAbstract RegAbs = new RegularEmployeeAbstract()
            {
                Name = "Prince",
                Gender = "Male",
                Day_Salary = 2000
            };
            Console.WriteLine(RegAbs.DisplayName_Gender());
            Console.WriteLine(RegAbs.CalCulateMonthlySalary());
            Console.WriteLine("----------------------------------");
            ContractEmployeeAbstract CtrtAbs = new ContractEmployeeAbstract()
            {
                Name = "Ram",
                Gender = "Male",
                Hour_Salary = 50,
                TotalHoursWorked = 1500,
            };
            Console.WriteLine(CtrtAbs.DisplayName_Gender());
            Console.WriteLine(CtrtAbs.CalCulateMonthlySalary());
            Console.ReadLine();
            #endregion
        }

    }
}
