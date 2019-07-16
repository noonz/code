using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Average Word Length

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            float total,word_length;
            total = 0;
            word_length = 0;

            bool keep_asking = true;

            while (keep_asking)
            {
                Console.Write("Enter a word: ");
                string word = Console.ReadLine();

                if (word == "")
                    break;

                word_length += word.Length;
                total += 1;
            }

            Console.WriteLine("You entered {0} words, the average length is {1:0}", total, word_length / total);
            Console.ReadLine();
        }
    }
}
