using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo
{
    public class FemaleEmployee : Employee
    {
        public FemaleEmployee()
        {
            _salary = 1000;
            _factor = 0.8;
        }
    }
}
