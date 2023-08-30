using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__2
{
    //Partial Class:
    //5. Define a partial class Person with one part containing properties like FirstName and LastName, and another part with methods like PrintFullName to display the full name.Implement these parts in separate files.

    partial class Person
    {
        public void printFullName()
        {
            Console.WriteLine($"My Name is {Firstname} {Lastname}");
        }
    }

}
