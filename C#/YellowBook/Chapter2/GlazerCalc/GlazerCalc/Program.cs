using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlazerCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            float width, height, wood_length, glass_area;

            const float MAX_WIDTH = 5.0f;
            const float MIN_WIDTH = 0.5f;
            const float MAX_HEIGHT = 3.0f;
            const float MIN_HEIGHT = 0.75f;
            string width_string, height_string;

            do
            {
                Console.Write("Width of window between {0} and {1}: ",MIN_WIDTH,MAX_WIDTH);
                width_string = Console.ReadLine();
                width = float.Parse(width_string);
            } while (width < MIN_WIDTH || width > MAX_WIDTH);

            do
            {
                Console.Write("Enter height between {0} and {1}: ",MIN_HEIGHT,MAX_HEIGHT);
                height_string = Console.ReadLine();
                height = float.Parse(height_string);
            } while (height < MIN_HEIGHT || height > MAX_HEIGHT);

            wood_length = 2 * (width + height) * 3.25f;
            glass_area = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + wood_length + " feet");
            Console.WriteLine("The area of the glass is " + glass_area + " square metres");
            Console.ReadLine();
        }
    }
}
