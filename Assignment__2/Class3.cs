using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__2
{
    //Static Class:
    //3. Create a static utility class named MathHelper with a static method CalculateAverage that takes an array of integers as input and returns their average.

    static class MathHelper
    {
        public static int[] arr = { 10, 25, 33, 89, 78 };
        public static double Avg = 0;
        public static double CalculateAverage()
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Avg = sum / arr.Length;
            return Avg;
        }


    }
    //4. Implement a static logger class called Logger that has a method LogMessage for writing messages on console. Demonstrate its usage in a simple console application.
    static class Logger
    {
        public static void LogMessage()
        {
            Console.WriteLine("This is Static Log Class");
        }

    }


}
