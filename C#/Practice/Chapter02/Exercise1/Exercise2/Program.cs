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
            Console.Write("Name: ");
            string firstName = Console.ReadLine();
            Console.Write("City: ");
            string userCity = Console.ReadLine();
            Console.Write("Phone : ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Program: ");
            string program = Console.ReadLine();

            Console.WriteLine("\nYour info");
            Console.WriteLine("------------------");
            Console.WriteLine("Name: {0}\nCity: {1}\nPhone: {2}\nProgram: {3}", firstName, userCity, phoneNumber, program);
            Console.ReadLine();

        }
    }
}
