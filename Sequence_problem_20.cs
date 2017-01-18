using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_practice_problems
{
    class Sequence_problem_20
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter width");
            int width = int.Parse(Console.ReadLine());
            for(int i=0;i<width;i++)
            {
                for(int j=0;j<width;j++)
                {
                    Console.Write(n);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
