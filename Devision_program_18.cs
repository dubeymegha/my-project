using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_practice_problems
{
    class Devision_program_18
    {
        static void Main(string[] args)
        {
            for(int i=0;i<10;i++)
            {
            Console.WriteLine("number1 ?");
            int n1=int.Parse(Console.ReadLine());
            Console.WriteLine("number2 ?");
            int n2=int.Parse(Console.ReadLine());

            if (n1==0)
            {
                Console.WriteLine("Bye");
                break;
            }
            if(n2==0)
            {
                Console.WriteLine("cannot devide by 0");
            }
                if(n1!=0 && n2!=0)
                {
                    Console.WriteLine("Devision is "+n1/n2);
                    Console.WriteLine("Reaminder is "+n1%n2);
                }
        }
            Console.ReadKey();
        }
    }
}
