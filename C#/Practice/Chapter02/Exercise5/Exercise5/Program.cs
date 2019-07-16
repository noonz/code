using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int carSpeed = 70;

            Console.WriteLine("Car speed: {0}m/h", carSpeed);
            Console.WriteLine("\nDistance after x hours in miles");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Six hours: {0}\nTen hours: {1}\n15 hours: {2}", (carSpeed * 6), (carSpeed * 10), (carSpeed * 15));
            Console.ReadLine();
        }
    }
}
