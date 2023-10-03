using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Constructor
{
    public  class Para_Cons
    {
       //string s;
        public Para_Cons(string s) 
        {
          // this.s = s;
          Console.WriteLine(s);
        }
         public static void Main(string[] args)
         {
            Para_Cons p1 = new Para_Cons("This is a Parametrised Constructor");
           // Console.WriteLine(p1.s);
        }
        }
    }

