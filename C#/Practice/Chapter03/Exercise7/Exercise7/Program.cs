using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Grade Calculator

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int test_one, test_two, exam;

            Console.Write("Enter test 1 mark: ");
            test_one = int.Parse(Console.ReadLine());
            check_test_score(test_one);

            Console.Write("Enter test 2 mark: ");
            test_two = int.Parse(Console.ReadLine());
            check_test_score(test_two);

            Console.Write("Enter exam mark: ");
            exam = int.Parse(Console.ReadLine());
            check_exam_score(exam);

            int total;
            total = test_one + test_two + exam;

            if (total > 79)
            {
                Console.WriteLine("Good job");
            }
            else if (total > 59)
            {
                Console.WriteLine("Credit earned.");
            }
            else if (total > 49)
            {
                Console.WriteLine("Pass. Barely. Noob.");
            }
            else
            {
                Console.WriteLine("Go back to school, you failed");
            }

            Console.ReadLine();
        }

        static void check_test_score (int test)
        {
            if (test > 25 || test < 0)
            {
                Console.WriteLine("Not a valid test score, use 0-25");
            }
        }
        
        static void check_exam_score (int exam)
        {
            if (exam > 50 || exam < 0)
            {
                Console.WriteLine("not a valid exam score, use 0-50");
            }
        }
    }
}
