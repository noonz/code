using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            float weight, mass;
            Console.Write("Enter object mass: ");
            mass = float.Parse(Console.ReadLine());

            weight = mass * 9.8f;

            if (weight > 500)
            {
                Console.WriteLine("Object is too heavy.");
            }
            else if (weight < 100)
            {
                Console.WriteLine("Object is too light.");
            }
            else
            {
                Console.WriteLine("Your object weighs {0} newtons.", weight);
            }
            Console.ReadLine();

        }
    }
}
