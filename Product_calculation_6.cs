using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_practice_problems
{
    class Product_calculation_6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter no ");
            int n = int.Parse(Console.ReadLine());
            if (n != 0)
            {
                Console.WriteLine("enter second no");
                int n1=int.Parse(Console.ReadLine());
                Console.WriteLine(n*n1);
            }
            else
                Console.WriteLine("0");
            Console.ReadKey();
        }
        }
}

