using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//String Repeater

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Repeat a word: ");
            string word = Console.ReadLine();
            Console.Write("Pick times to repeat it: ");
            int count = int.Parse(Console.ReadLine());

            string result = repeat(word, count);
            Console.WriteLine(result);
            Console.ReadLine();

        }

        static string repeat(string s, int n)
        {
            var result = s;

            for (var i = 0; i < n-1; i++)
            {
                result += s;
            }

            return result;
        }
    }
}
