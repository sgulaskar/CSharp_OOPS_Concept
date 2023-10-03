// C# program to calculate the area
// of a square using the concept of
// data abstraction
using System;

namespace Demoabstraction
{
    abstract class Shape         // abstract class
    {
        public abstract int area();     // abstract method
    }

    // square class inheriting the Shape class
    class Square : Shape
    {
        private int side;    // private data member

        public Square(int x = 0)          // method of square class
        {
            side = x;
        }

        // overriding of the abstract method of Shape
        // class using the override keyword
        public override int area()
        {
            Console.Write("Area of Square: ");
            return (side * side);
        }
    }

    class AbstractionDemo
    { 
        static void Main(string[] args)          // Main Method
        {

            // creating reference of Shape class
            // which refer to Square class instance
            Shape sh = new Square(4);

            // calling the method
            double result = sh.area();
            Console.WriteLine ("{0}", result);

        }
    }
}
