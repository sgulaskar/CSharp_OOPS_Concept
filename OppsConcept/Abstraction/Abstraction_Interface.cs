using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Abstraction
{
        public interface IShape
        {
            public void Draw(); // Abstract method
        }

        public class Circle : IShape   // Implement the interface in a class
    {
        public void Draw()
            {
                Console.WriteLine("Drawing a circle");
            }
        }
        public class Square : IShape
        {
            public void Draw()
            {
                Console.WriteLine("Drawing a square");
            }
        }
    public class Abstraction_Interface
    {
        public static void Main()
        {
            // Create objects of the classes implementing the interface
            IShape circle = new Circle();
            IShape square = new Square();

            // Call the abstract method on each object
            circle.Draw(); // Output: Drawing a circle
            square.Draw(); // Output: Drawing a square
        }


    }
}
