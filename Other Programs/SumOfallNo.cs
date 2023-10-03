using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Other_Programs
{
    public  class SumOfallNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by spaces:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;

            foreach (string number in numbers)
            {
                sum += int.Parse(number);
            }

            Console.WriteLine($"Sum of given numbers: {sum}");
        }
    }

}
