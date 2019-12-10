using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo
{
    public class EmployeeWithSwimmingDiploma : EmployeeWithDiploma
    {
        public EmployeeWithSwimmingDiploma(Employee employee) : base(employee)
        {
            _factor = 1.1;
        }

    }
}
