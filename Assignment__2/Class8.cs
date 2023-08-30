using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__2
{
    //7. Define an abstract base class Shape with an abstract method CalculateArea. Derive classes like Circle and Rectangle from Shape and implement the area calculation methods for each.

    public abstract class Shape
    {
        public abstract void CalculateArea();
    }

    public class Circle : Shape
    {
        public override void CalculateArea()
        {
            int r = 15;
            double area = 3.14 * (r * r);
            Console.WriteLine("Area of the Circle : " + area);
        }
    }

    public class Rectangle : Shape
    {
        public override void CalculateArea()
        {
            int l = 15;
            int b = 54;
            double area = l * b;
            Console.WriteLine("Area of Rectangle : " + area);
        }
    }
    //8. Design an abstract class Animal with properties like Name and Age. Derive classes like Dog and Cat from Animal with their unique methods.

    public abstract class Animal
    {
        public string Name;
        public int Age;
    }
    public class Cat : Animal
    {
        public void Details()
        {
            Name = "Littin";
            Age = 5;
            Console.WriteLine("Cat Name is " + Name + " and her age is " + Age);
        }
    }


}
