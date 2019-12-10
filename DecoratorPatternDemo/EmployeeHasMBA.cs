using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo
{
    class EmployeeHasMBA : EmployeeWithDiploma
    {
        public EmployeeHasMBA(Employee employee) : base(employee)
        {
            _factor = 2;
        }
    }
}
