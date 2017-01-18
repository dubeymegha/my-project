using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_practice_problems
{
    class Multiplesof_3and5_14
    {
        static void Main(string[] args)
        { 
         for(int i=1;i<=500;i++)
         {
             if(i%3==0 && i%5==0 )
             {
                 Console.WriteLine(i);
             }
         }
         Console.ReadKey();
        }
    }
}
