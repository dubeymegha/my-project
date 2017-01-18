using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_practice_problems
{
    class print_oddno_using_while_10
    {
        static void Main(string[] args)
        {
            int n = 15;
            while (n >= 7)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n);
                }
                n--;
            }
            Console.ReadKey();
        }
    }
}
