using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_practice_problems
{
    class printing_odd_no_on_conditions_21
    {
        static void Main(string[] args)
        {
            for (int i = 10; i <= 20; i++)
            { 
            if(i%2==0 && i!=16)
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
