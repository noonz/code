using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Automobile Costs

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            float loan, insurance, gas, oil, tires, other;

            Console.Write("Enter monthly loan cost: ");
            loan = float.Parse(Console.ReadLine());

            Console.Write("Enter monthly insurance cost: ");
            insurance = float.Parse(Console.ReadLine());

            Console.Write("Enter monthly gas cost: ");
            gas = float.Parse(Console.ReadLine());

            Console.Write("Enter monthly oil cost: ");
            oil = float.Parse(Console.ReadLine());

            Console.Write("Enter monthly tires cost: ");
            tires = float.Parse(Console.ReadLine());

            Console.Write("Enter monthly other cost: ");
            other = float.Parse(Console.ReadLine());

            float total = loan + insurance + gas + oil + tires + other;
            Console.WriteLine("Monthly costs: {0:c}\nYearly Cost: {1:c}", total, total * 12);
            Console.ReadLine();
        }
    }
}
