using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept
{
    public class father
    {
        public void fatherofchild()
        {
            Console.WriteLine("father");
        }
    }
    public class Firstchild:father
    {
        public void first()
        {
            Console.WriteLine("first");
        }
    }
    public class SecondChild : father
    {
        public void second()
        {
            Console.WriteLine("second");
        }
    }
    public class ThirdChild : father
    {
        public void third()
        {
            Console.WriteLine("third");
        }
    }

    public class Hierarchical_Inheritance
    {
       
        static void Main(string[] args)
        {
            Firstchild f1 = new Firstchild();
            f1.fatherofchild();
            f1.first();
            SecondChild s1 = new SecondChild();
            s1.second();
            ThirdChild t1 = new ThirdChild();
            t1.third();
            
        }
    }
}
