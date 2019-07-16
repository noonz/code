using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Bug Collector

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int bugs;
            bugs = 0;

            for (int days = 0; days < 5; days++)
            {
                Console.Write("Enter bugs collect day {0}: ", days + 1);
                bugs += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("You've collected {0} bugs over 5 days.",bugs);
            Console.ReadLine();
        }
    }
}
