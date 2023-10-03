using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept
{
    public interface IFirst
    {
        public void FirstMethod();
    }
    public interface ISecond
    {
        public void SecondMethod();
    }
    public class Display : IFirst, ISecond
    {
        public void FirstMethod()
        {
            Console.WriteLine("First");
        }
        public void SecondMethod()
        {
            Console.WriteLine("Second");
        }
    }
    public class Multiple_Inhertance
    {
        public static void Main()
        {
            Display obj1 = new Display();
            obj1.FirstMethod();
            obj1.SecondMethod();
        }
    }
}


   
        
    

