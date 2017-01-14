using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_practice_problems
{
    class Star_pattern_5
    {
        static void Main(string[] args)
        {
            int n=1;
          for(int i=0;i<7;i++)
          {
              for(int j=1;j<=i+1;j++)
              {
                  Console.Write(j);
              }
              for (int k = n; k < 7;k++ )
              {
                  Console.Write("*");
              }
                  Console.WriteLine();
                  n++;
          }
          Console.ReadKey();
        }
    }
}
