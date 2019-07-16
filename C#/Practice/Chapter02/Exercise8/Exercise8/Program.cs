using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            float tipAmount = 0.18f;
            float taxAmount = 0.07f;

            Console.Write("Food cost: $");
            float foodCost = float.Parse(Console.ReadLine());

            Console.WriteLine("\nTip: ${0:F2}", foodCost * tipAmount);
            Console.WriteLine("Tax: ${0:F2}", foodCost * taxAmount);
            Console.WriteLine("Total: ${0:F2}", foodCost + (foodCost * tipAmount) + (foodCost * taxAmount));
            Console.ReadLine();

        }
    }
}
