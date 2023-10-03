using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept
{
    public class Schools
    {
        public void Primery()
        {
            Console.WriteLine("Schools is after Primery");
        }
    }
    public class Highschool : Schools
    {
        public void School()
        {
            Console.WriteLine("Highschool is after school");
        }
    }
    public class Colleage : Highschool
    {
        public void Highschool()
        {
            Console.WriteLine("Colleage is after Highschool");
        }
    }
    public class Multilevel_inhertance
    {
        static void Main(string[] args)
        {
            Colleage c1 = new Colleage();
            c1.Primery();
            c1.School();
            c1.Highschool();

        }
    }
}

