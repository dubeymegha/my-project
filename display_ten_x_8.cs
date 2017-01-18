using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_practice_problems
{
    class display_ten_x_8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter no");
            int n = int.Parse(Console.ReadLine());
            while(n!=0)
            {
                Console.WriteLine(10*n);
                Console.WriteLine("enter no");
                n = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
