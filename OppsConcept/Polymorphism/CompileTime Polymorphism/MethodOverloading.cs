using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Polymorphism.CompileTime_Polymorphism
{
    public class MethodOverloading
    {
        public void Add(int a,int b)
        {
            int c = a + b;
            Console.WriteLine("addition is " + c);
        }
        public void Add(double a, double b)
        {
            //double c = a + b;
            Console.WriteLine("addition is " + (a+b));
        }
        public void Add(string s1,string s2)
        {
            Console.WriteLine("Cancatination of two string is "+ s1 + s2);
        }
        static void Main()
        {
            MethodOverloading m1 = new MethodOverloading();
            m1.Add(56, 8);
            m1.Add(15.5,2);
            m1.Add("san", "gram");
        }
    }
}
