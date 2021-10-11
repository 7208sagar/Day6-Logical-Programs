using System;

namespace Day6_Logical_Programs
{
    //prime number
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int Number = 0, i, m = 0, flag = 0;
            Console.WriteLine("Enter the number to check prime");

            Number = int.Parse(Console.ReadLine());
            m = Number / 2;

            for (i = 2; i <= m; i++)
            {
                if (Number % i == 0)
                { 
                    flag = 1;
                    break;
                }
                if (flag == 0)
                {
                    Console.WriteLine("Number is Prime " + Number);
                }
                else
                {
                    Console.WriteLine("Number is not Prime "+Number);
                }
                Console.ReadLine();
            }

        }
    }
    
}
