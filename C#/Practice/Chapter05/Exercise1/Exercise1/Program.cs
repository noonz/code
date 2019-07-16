using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Kilometer Converter

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Kilometers: ");
            float kilometers = float.Parse(Console.ReadLine());
            float miles = convert_km(kilometers);

            Console.WriteLine("Miles: {0:.##}",miles);

            Console.ReadLine();
        }

        static float convert_km(float kilometers)
        {
            return kilometers * 0.6214f;
        }
    }
}
