using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_practice_problems
{
    class find_pisotiveornegative_5
    {
        static void Main5(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            if(n>=0)
                Console.WriteLine("no is positive");
            else
                Console.WriteLine("no is negative");
            Console.ReadKey();
        }
    }
}
