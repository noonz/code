using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Stadium Seating

namespace Exercise7
{
    class Program
    {
        static int CLASS_A = 20;
        static int CLASS_B = 15;
        static int CLASS_C = 10;

        static void Main(string[] args)
        {
            Console.Write("Enter Class A sales: ");
            int a_sales = int.Parse(Console.ReadLine());

            Console.Write("Enter Class B sales: ");
            int b_sales = int.Parse(Console.ReadLine());

            Console.Write("Enter Class C sales: ");
            int c_sales = int.Parse(Console.ReadLine());

            Console.Write("Class A Sales: {0:c}\nClass B Sales: {1:c}\nClass C Sales: {2:c}",
                get_classa_sales(a_sales), get_classb_sales(b_sales), get_classc_sales(c_sales));
            Console.ReadLine();
        }

        static int get_classa_sales(int n)
        {
            return n * CLASS_A;
        }
        static int get_classb_sales(int n)
        {
            return n * CLASS_B;
        }
        static int get_classc_sales(int n)
        {
            return n * CLASS_C;
        }
    }
}
