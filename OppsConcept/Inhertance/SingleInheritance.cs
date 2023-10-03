using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept
{
    public class Vehicle
    {
        public void Gear(string n)
        {
            Console.WriteLine(" "+ n + "Vehicle is in gearMode");
        }
        public void accelerate()
        {
            Console.WriteLine(" Vehivle is in AccelerateMode");
        }
    }
    public class Car : Vehicle
    {
        public void Break()
        {
            Console.WriteLine(" Car is in BreakeMode");
        }
    }
    public class SingleInheritance
    { 
        static void Main(string[] args)
        {
            
            Car c1 = new Car();
            c1.accelerate();
            c1.Gear("new");
            c1.Break();

        }
    }
}
