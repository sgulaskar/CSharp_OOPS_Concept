using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Constructor
{
    public class Default_Con
    {
        public Default_Con()            //Default Constructor
        {
            Console.WriteLine("This is default Constructor");
        }    
        public static void Main() 
        {
            Default_Con d1=new Default_Con();
        }
    }
}
