using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee doug = new MaleEmployee();
            Employee dougCanSwim = new EmployeeWithSwimmingDiploma(doug);
            Console.WriteLine(string.Format("Doug earns {0} a month", dougCanSwim.CalculateSalary()));

            Employee ashley = new FemaleEmployee();
            Employee ashleyCanSwim = new EmployeeWithSwimmingDiploma(ashley);
            Employee ashleyCanSwimAndHasMBA = new EmployeeHasMBA(ashleyCanSwim);
            Console.WriteLine(string.Format("Ashley earns {0} a month", ashleyCanSwimAndHasMBA.CalculateSalary()));

            Employee george = new MaleEmployee();
            Employee georgeHasMBA = new EmployeeHasMBA(george);
            EmployeeWithSwimmingDiploma georgeHasMBAandCanSwim = new EmployeeWithSwimmingDiploma(georgeHasMBA);
            Console.WriteLine(string.Format("George earns {0} a month", georgeHasMBAandCanSwim.CalculateSalary()));

            Console.ReadKey();


        }
    }
}
