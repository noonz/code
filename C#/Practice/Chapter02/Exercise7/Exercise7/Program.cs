using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Miles driven: ");
            int userMiles = Convert.ToInt32(Console.ReadLine());

            Console.Write("Gallons used: ");
            float userGallons = float.Parse(Console.ReadLine());

            Console.WriteLine("Total MPG: {0:F2}/gallon", userMiles / userGallons);
            Console.ReadLine();
        }
    }
}
