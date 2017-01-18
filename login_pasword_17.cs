using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_practice_problems
{
    class login_pasword_17
    {
        static void Main(string[] args)
        {
            bool check = false;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter login");
                int login = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter pass");
                int password = int.Parse(Console.ReadLine());
                while(login==12 && password==1234)
                {
                    Console.WriteLine("Login Successful");
                    check = true;
                    break;

                }
                if (check == true)
                    break;
            }
            Console.ReadKey();
        }
    }
}
