using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__2
{
    internal class Class9
    {
        // 9. Create a base class Vehicle with methods like StartEngine and StopEngine.Derive a class Car from Vehicle and seal it.Try to create a class that inherits from Car and observe the behavior.

        public class Vehicle
        {
            public void StartEngine()
            {
                Console.WriteLine("Start Engine Method");

            }
            public void StopEngine()
            {
                Console.WriteLine("Stop Engine Method");
            }
        }

        sealed class Car:Vehicle
        {
            public Car()
            {
                Console.WriteLine("Sealed Class ");
            }
        }
        class A: Car
        {
            // Error Occur Because Seales class can't be innherited 

        }
    }

}

