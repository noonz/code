using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//How Much Insurance?

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter cost of unit: $");
            int cost = int.Parse(Console.ReadLine());

            Console.WriteLine("Minimum Insurance: {0:C}", get_insurance(cost));
            Console.ReadLine();
        }

        static float get_insurance(int n)
        {
            return n * .80f;
        }
    }
}
