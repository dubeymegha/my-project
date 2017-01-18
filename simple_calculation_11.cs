using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_practice_problems
{
    class simple_calculation_11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number ?");
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            while(n!=0)
            {
                total = total + n;
                Console.WriteLine("Total "+total);
                Console.WriteLine("Enter number ?");
                n = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
