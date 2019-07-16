using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Magic Dates

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int month, day, year;

            Console.Write("Enter a month: ");
            month = int.Parse(Console.ReadLine());

            Console.Write("Enter a Day: ");
            day = int.Parse(Console.ReadLine());

            Console.Write("Enter a year: ");
            year = int.Parse(Console.ReadLine());

            if (month * day == year)
            {
                Console.WriteLine("This date is magic.");
            }
            else
            {
                Console.WriteLine("This date is not magic.");
            }
            Console.ReadLine();

        }
    }
}
