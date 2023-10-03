using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Constructor
{
    public class Copy_Cons
    {
        int x;
        public Copy_Cons(int i) 
        {
            x=i;
        }
        public Copy_Cons(Copy_Cons obj)
        {
            x= obj.x;
        }
        public void Display()
        {
            Console.WriteLine("This is a Copy Constructor"+x);
        }
        static void Main()
        { 
            Copy_Cons c1=new Copy_Cons(10);
            Copy_Cons c2 = new Copy_Cons(c1);
            c1.Display();
        }
    }
}
