using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************ 1 Instance class ***************");
            Employee obj = new Employee();
            obj.Show();

            BankAccount account = new BankAccount();
            account.Show_Details();

            Console.WriteLine("************** 3 Static Class**************");

            Console.WriteLine("Average of Elements of Array : " + MathHelper.CalculateAverage());

            Console.WriteLine("************** 4 **************");

            Logger.LogMessage();

            Console.WriteLine("************** 5 Partial class **************");

            Person person = new Person();
            person.printFullName();

            Console.WriteLine("************** 6 **************");
            Employee2 emp2 = new Employee2();
            emp2.Calculatesalary();

            Console.WriteLine("************** 7 Abstarct class **************");
            Circle circle = new Circle();
            circle.CalculateArea();

            Rectangle rect = new Rectangle();
            rect.CalculateArea();
            Console.WriteLine("************** 8  **************");

            Cat c = new Cat();
            c.Details();



        }
    }
}
