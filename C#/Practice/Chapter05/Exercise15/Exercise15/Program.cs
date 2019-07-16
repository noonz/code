using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Test Average and Grade

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter test score 1: ");
            int score_1 = int.Parse(Console.ReadLine());

            Console.Write("Enter test score 2: ");
            int score_2 = int.Parse(Console.ReadLine());

            Console.Write("Enter test score 3: ");
            int score_3 = int.Parse(Console.ReadLine());

            Console.WriteLine(calc_average(score_1, score_2, score_3));
            Console.ReadLine();
        }

        static int calc_average(int x, int y, int z)
        {
            int total = x + y + z;

            return total / 3;
        }

        static void determine_grade()
        {
        
        }
    }
}
