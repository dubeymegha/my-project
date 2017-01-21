using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_practice_problems
{
    class Hollow_square_25
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "This is modified");
            Console.WriteLine("Enter symbol");
            int symbol = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter width");
            int width = int.Parse(Console.ReadLine());

            //for first row
            for(int i=0;i<width;i++)
                Console.Write(symbol);
            Console.WriteLine();

            for (int i = 0; i < width-2;i++ )
            {
                Console.Write(symbol);
            for(int j=0;j<width-2;j++)
            {
                Console.Write(" ");
            }
            Console.Write(symbol);
            Console.WriteLine();
            }
            
                //for last row
                for (int i = 0; i < width; i++)
                    Console.Write(symbol);
                Console.ReadKey();
        }
    }
}
