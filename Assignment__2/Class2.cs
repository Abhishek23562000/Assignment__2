using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__2
{
    public class Employee
    {
        public string name;
        public int age;
        public double salary;

        public Employee()
        {
            name = "Abhishek";
            age = 23;
            salary = 40500;
        }
        public void Show()
        {
            Console.WriteLine("Name of the Employess : " + name);
            Console.WriteLine("Age of the Employee : " + age);
            Console.WriteLine("Salary of the Emloyee : " + salary);

        }



    }
    //2. Create a class called BankAccount with properties for account number, account holder name, and balance. Implement methods for deposit, withdrawal, and displaying the account details.

    class BankAccount
    {
        public string Holder_name;
        public long Acc_number;
        public double balance;

        public BankAccount()
        {
            Holder_name = "Abhishek";
            Acc_number = 2284200004;
            balance = 14561.8974;
        }
        public void Show_Details()
        {
            Console.WriteLine("Account Holder Name : " + Holder_name);
            Console.WriteLine("Account Number : " + Acc_number);
            Console.WriteLine("Account Balance : " + balance);
        }

    }


}
