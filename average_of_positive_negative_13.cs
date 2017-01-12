using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class average_of_positive_negative_13
    {
        static void Main13(string[] args)
        {
            int[] arr=new int[10];
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                Console.WriteLine("Enter real no.");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0, res = 0;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if(arr[i]>0)
                {
                    sum = sum + arr[i];
                }
                else
                {
                    res = res + arr[i];
                }
            }
            Console.WriteLine("Average of positive integer is "+sum);
            Console.WriteLine("Average of negative integer is " + res);
            Console.ReadKey();

        }
    }
}
