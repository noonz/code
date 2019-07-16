using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            float conversionRate = 0.454f;

            Console.Write("Enter number to convert to KG: ");
            float pounds = float.Parse(Console.ReadLine());

            Console.Write("Pounds: {0}\nKG: {1}", pounds, (pounds * conversionRate));
            Console.ReadLine();

        }
    }
}
