using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Quarter of the Year

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a month number of the year: ");
            int userMonth = int.Parse(Console.ReadLine());

            if (userMonth > 0 && userMonth < 4)
                Console.WriteLine("Your month is in the first quarter");
            else if (userMonth > 3 && userMonth < 7)
                Console.WriteLine("Your month is in the second quarter");
            else if (userMonth > 6 && userMonth < 10)
                Console.WriteLine("Your month is in the third quarter");
            else
                Console.WriteLine("Your month is in the fourth quarter");

            Console.ReadLine();
        }
    }
}
