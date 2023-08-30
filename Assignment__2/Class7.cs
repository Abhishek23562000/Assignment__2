using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__2
{
    //6. Create a partial class Employee with properties representing employee details. In another part, implement methods for calculating salary based on different factors.
    partial class Employee2
    {
        public double salary = 0;
        public void Calculatesalary()
        {
            salary = base_salary + bonus;
            Console.WriteLine("Salary of the Employee : " + salary);
        }
    }

}
