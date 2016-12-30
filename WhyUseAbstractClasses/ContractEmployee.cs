using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyUseAbstractClasses
{
    class ContractEmployee : BaseEmployee
    {

        public int HourlyWage { get; set; }
        public int TotalHours { get; set; }

        public override int GetMonthlySalary()
        {
            return (this.HourlyWage * this.TotalHours);
        }

    }
}
