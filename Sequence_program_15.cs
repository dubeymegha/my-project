using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_practice_problems
{
    class Sequence_program_15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount");
            int a = int.Parse(Console.ReadLine());
            for(int i=0;i<a;i++)
            {
                Console.Write(n);
            }
            Console.ReadKey();
        }
    }
}
