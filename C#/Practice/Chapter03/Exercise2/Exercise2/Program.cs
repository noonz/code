using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Area of Rectangles

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter rectangle 1 length: ");
            float rectLength1 = float.Parse(Console.ReadLine());

            Console.Write("Enter rectangle 1 width: ");
            float rectWidth1 = float.Parse(Console.ReadLine());

            float rectArea1 = rectLength1 * rectWidth1;

            Console.Write("Enter rectangle 2 length: ");
            float rectLength2 = float.Parse(Console.ReadLine());

            Console.Write("Enter rectangle 2 width: ");
            float rectWidth2 = float.Parse(Console.ReadLine());

            float rectArea2 = rectLength2 * rectWidth2;

            if (rectArea1 > rectArea2)
                Console.WriteLine("rectangle 1 has a larger area");
            else if (rectArea1 < rectArea2)
                Console.WriteLine("rectangle 2 has a larger area");
            else
                Console.WriteLine("Both areas are the same");
            Console.ReadLine();
        }
    }
}
