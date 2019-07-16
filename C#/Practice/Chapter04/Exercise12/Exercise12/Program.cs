using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Calculating the Factorial of a Number

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 1;

            Console.WriteLine("Factorials\n--------------");
            Console.Write("Enter a number: ");
            int user_num = int.Parse(Console.ReadLine());

            for (int i = 1; i < user_num + 1; i++)
            {
                total *= i;
                if (i == user_num){
                    Console.Write("{0} = ",i);
                    break;
                }
                else
                {
                    Console.Write("{0} x ", i);
                }
            }
            Console.WriteLine(total.ToString("n0"));
            Console.ReadLine();

        }
    }
}
