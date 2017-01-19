using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_practice_problems
{
    class Hollow_rectangle_28
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Symbol");
            int symbol = int.Parse(Console.ReadLine());
            Console.WriteLine("width?");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Height");
            int height = int.Parse(Console.ReadLine());

            for(int i=0;i<width;i++)
                Console.Write(symbol);
            Console.WriteLine();

            for (int i = 0; i < height - 2;i++ )
            {
                Console.Write(symbol);
                for(int j=0;j<width-2;j++)
                {
                    Console.Write(" ");
                }
                Console.Write(symbol);
                Console.WriteLine();
            }

                for (int i = 0; i < width; i++)
                    Console.Write(symbol);

                Console.ReadKey();
        }
    }
}
