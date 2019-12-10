using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo
{
    public class MaleEmployee : Employee
    {

        public MaleEmployee()
        {
            _salary = 1000;
            _factor = 1;
        }

    }
}
