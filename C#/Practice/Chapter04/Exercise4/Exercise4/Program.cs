using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Distance Traveled

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours, speed, distance;
            distance = 0;

            Console.Write("Enter speed: ");
            speed = int.Parse(Console.ReadLine());

            Console.Write("Enter Hours driven: ");
            hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Hours         Distance");
            Console.WriteLine("----------------------");

            for (int i = 0; i < hours; i++)
            {
                distance += speed;
                Console.WriteLine("{0,3}{1,16}", i+1, distance);
            }
            Console.ReadLine();
            
        }
    }
}
