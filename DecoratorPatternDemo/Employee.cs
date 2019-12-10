using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo
{
    public abstract class Employee
    {
        protected double _salary;
        protected double _factor;


        public virtual double CalculateSalary()
        {
            return _salary * _factor;
        }

       
    }
}
