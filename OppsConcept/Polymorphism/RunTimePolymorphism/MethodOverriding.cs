using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Polymorphism.RunTimePolymorphism
{
    public class Polygon
    {
        public virtual void Render(string s1)
        {
            Console.WriteLine(s1);
        }
    }
    public class Triangle:Polygon
    {
        public override void Render(string s1)
        {
            Console.WriteLine(s1);
        }
    }
    public  class MethodOverriding
    {
        static void Main()
        {
            Polygon p1 = new Polygon(); //p1 is the object of Polygon class
            p1.Render("Polygon is rendering");    //calls render() method of Polygon Superclass 
            p1 = new Triangle();  //here,p1 is the object of derived class Triangle 
            p1.Render("Triangle is rendering");   //alls render() method of derived class Triangle 
        }
    }
}
