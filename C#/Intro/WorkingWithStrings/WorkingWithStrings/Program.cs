using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = "What if I need a\nnew line?";
            //string myString = "Go to your c:\\ drive";
            //string myString = @"Go to your c:\ drive";
            //string myString = String.Format("{0} - {1}", "First", "Second");
            //string myString = string.Format("{0:C}",123.45); //Convert to money
            //string myString = string.Format("{0:N}",1234567890); // Convert to number with commas
            //string myString = string.Format("Percentage: {0:P}",.123); // Converts to percentage
            //string myString = string.Format("Phone Number: {0:(###) ###-####}",1234567890); // Convert to a phone number
            //string myString = " That summer we took threes across the board  ";

            //myString = myString.Substring(6,14); //truncate
            //myString = myString.ToUpper(); // Convert to Upper Case ToLower() for another
            //myString = myString.Replace(" ", "--"); // replace first arg with second
            //myString = myString.Remove(6,14); // remove characters
            //myString = String.Format("Length before: {0} -- Length After: {1}",myString.Length, myString.Trim().Length);

            /*
            string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
