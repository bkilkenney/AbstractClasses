using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Use Abstract classes when there is common functionality in derived classes
//2. D-R-Y w/o abrstract BaseEmployee you'd have to change all the different employee types
//3. Do NOT want to instantiate the BaseEmployee class, Abstract prevents this

namespace WhyUseAbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee()
            {
                ID = 101,
                FirstName = "Brad",
                LastName = "Kilkenney",
                AnnualSalary = 65000              
            };

            Console.WriteLine(fte.GetFullName());
            Console.WriteLine(fte.GetMonthlySalary());

            Console.WriteLine("----------------------");

            ContractEmployee cte = new ContractEmployee()
            {
                ID = 102,
                FirstName = "Barry",
                LastName = "Sanders",
                HourlyWage = 25,
                TotalHours = 160
            };

            Console.WriteLine(cte.GetFullName());
            Console.WriteLine(cte.GetMonthlySalary());
        }
    }
}
