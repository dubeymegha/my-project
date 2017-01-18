using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_practice_problems
{
    class print_the_greatest_no_7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first no");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second no.");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter third number");
            int n3 = int.Parse(Console.ReadLine());
            
            if(n1>=n2 && n1>=n3)
                Console.WriteLine(n1+" is greater");
            else if(n2>=n1 && n2>=n3)
                Console.WriteLine(n2+" is greater");
            else 
                Console.WriteLine(n3+" is greater");

            Console.ReadKey();
        }
    }
}
