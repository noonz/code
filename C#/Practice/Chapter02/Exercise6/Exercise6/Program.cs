using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            float interest = 1.05f;

            Console.Write("Enter purchase amount: $");
            float purchaseAmount = float.Parse(Console.ReadLine());

            Console.Write("Enter number of instalments: ");
            int instalments = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nTotal: ${0:F2}", purchaseAmount * interest);
            Console.WriteLine("Each payment: ${0:F2}", (purchaseAmount * interest) / instalments);
            Console.ReadLine();
        }
    }
}
