using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Abstraction
{
    public abstract class Shape
    {
        public abstract void Draw();
    }
    public class Circle1 : Shape 
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");

        }
    }
    public class Square1:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Square");
        }
    }
    public class Demo
    {
        static void Main()
        {
            Shape circle1 = new Circle1();
            circle1.Draw();
            Shape square1= new Square1();
            square1.Draw();
        }
    }
}
