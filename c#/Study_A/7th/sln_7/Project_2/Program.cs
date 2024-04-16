using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 피라미드 반복문 **셤문제
            // [ ◣ ]
            for(int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            // [ ◢ ]
            for(int i = 1; i <= 10; i++)
            {
                for(int j = 1; j < 11 - i; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            // [ ▲ ] 1
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            // [ ▲ ] 2
            int max = 8;
            for(int i = 0; i < max; i++)
            {
                for(int j=max-1; j > i; j--) // 0 --> 7번, 1 --> 6번(2까지 반복)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }



        }
    }
}
