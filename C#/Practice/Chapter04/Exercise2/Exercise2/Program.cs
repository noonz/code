using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Calories Burned

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            float burned_calories;
            int minutes;
            burned_calories = 0;

            for (minutes = 10; minutes < 31; minutes+=5)
            {
                burned_calories += minutes * 4.2f;
                Console.WriteLine("You've burned {0} calories in {1} minutes.", burned_calories, minutes);
            }
            Console.ReadLine();
        }
    }
}
