using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber > 0)
            {
                Console.WriteLine("You entered a positive number");
                if (userNumber % 2 == 0)
                    Console.WriteLine("Your number is even");
                else
                    Console.WriteLine("Your number is odd");
            }
            else if (userNumber < 0)
            {
                Console.WriteLine("You entered a negative number");
                if (userNumber % 2 == 0)
                    Console.WriteLine("Your number is even");
                else
                    Console.WriteLine("Your number is odd");
            }
            else
            {
                Console.WriteLine("You entered 0");
            }
            Console.ReadLine();
        }
    }
}
