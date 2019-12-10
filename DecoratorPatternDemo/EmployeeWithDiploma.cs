using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo
{
    public class EmployeeWithDiploma : Employee
    {

        protected Employee _employee;
        public EmployeeWithDiploma(Employee employee)
        {
            _employee = employee;
        }


        public override double CalculateSalary()
        {
            return _employee.CalculateSalary() * _factor;
        }

    }
}
