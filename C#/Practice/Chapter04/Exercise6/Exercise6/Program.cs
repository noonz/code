using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Miles to Kilometers Table

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Miles          Kilometers");
            Console.WriteLine("--------------------------");

            for (int miles = 10; miles < 80; miles+=10)
            {
                Console.WriteLine("{0,3}{1,20:.##}",miles, miles*1.60934);
            }
            Console.ReadLine();
        }
    }
}
