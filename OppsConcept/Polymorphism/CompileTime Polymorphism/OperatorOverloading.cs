using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Polymorphism.CompileTime_Polymorphism
{
    public  class OperatorOverloading
    {
        public void Add(string s1, string s2)
        {
            string s = s1 + s2;
            Console.WriteLine("Cancatination of two string is " + s);
        }
        static void Main()
        {
            OperatorOverloading o1 = new OperatorOverloading();  
            o1.Add("san", "gram");
        }
    }
}
