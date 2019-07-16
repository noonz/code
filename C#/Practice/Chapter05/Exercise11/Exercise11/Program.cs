using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Addition Test

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            gen_questions();
            Console.ReadLine();
        }

        static void gen_questions()
        {
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                int num1 = random.Next(1, 11);
                int num2 = random.Next(1, 11);
                Console.WriteLine("Question {0}\n" + num1 + " + " + num2 + " = ",i+1);
            }
        }
    }
}
