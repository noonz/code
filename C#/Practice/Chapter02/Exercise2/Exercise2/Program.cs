using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            float interest = 0.23f;
            int sales = 0;

            Console.Write("Enter sales: ");
            sales = Convert.ToInt32(Console.ReadLine());

            float profit = sales * interest;
            Console.WriteLine("\nYearly sales with profit");
            Console.WriteLine("------------------------");
            Console.WriteLine("Sales: ${0}\nProfit: ${1}", sales, profit);
            Console.ReadLine();
        }
    }
}
