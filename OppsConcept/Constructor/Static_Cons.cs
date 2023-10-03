using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Constructor
{
    public class Static_Cons
    {
        public static int x; //Static variable
        static Static_Cons()   //static constructor  is invoked before the first
                               // instance constructor is run.
        {
            x = 10;
            Console.WriteLine("This is Static Constructor ");
        }
        public Static_Cons(int i)        // Instance constructor.
        {
            Console.WriteLine("Instance Constructor " + i);
        }

        static void Main()
        {
           Static_Cons s1 = new Static_Cons(10);// Instance constructor.called
            int value = Static_Cons.x;
        }

    }
}
