using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Dave's Giveaway");
            Console.Write("Choose door 1,2,3: ");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
                message = "You won a new car!";
            else if (userValue == "2")
                message = "You won a new boat!";
            else if (userValue == "3")
                message = "You won a new cat!";
            else
            {
                message = "You chose a number out of range. ";
                message += "You lose.";
            }

            Console.WriteLine(message);
            Console.ReadLine();
            */

            Console.WriteLine("Dave's Giveaway");
            Console.Write("Choose door 1,2,3: ");
            string userValue = Console.ReadLine();

            // only useful for an two condition scenario
            string message = (userValue == "1") ? "boat" : "strand of lint";

            Console.Write("You chose {0} , You won a {1}.", userValue, message);
            Console.ReadLine();
        }
    }
}
