using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            float salesTax = 0.07f;
            float total = 0.00f;

            Console.Write("Cost of item 1: $");
            total += float.Parse(Console.ReadLine());

            Console.Write("Cost of item 2: $");
            total += float.Parse(Console.ReadLine());

            Console.Write("Cost of item 2: $");
            total += float.Parse(Console.ReadLine());

            Console.WriteLine("Receipt");
            Console.WriteLine("----------");
            Console.WriteLine("Total: ${0}\nTax: ${1}\nGrand Total: ${2}", total, (total * salesTax), (total + (total*salesTax)));
            Console.ReadLine();
        }
    }
}
