using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Pennies for Pay

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            float pennies;
            pennies = 0.01f;

            Console.Write("Enter days to cycle your doubling salary in pennies: ");
            int days = int.Parse(Console.ReadLine());

            for (int i = 0; i < days; i++)
            {
                Console.WriteLine("Day: {0}\t\tSalary: {1:$0.##}",i+1, pennies);
                pennies *= 2;
            }
            Console.ReadLine();
        }
    }
}
