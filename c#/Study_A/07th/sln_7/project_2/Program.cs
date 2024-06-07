using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //중첩 반복문 : 별 피라미드(1)
            for (int i = 0; i < 10 ; i++)
            {
                for(int j = 0; j < i + 1 ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //별 피라미드(2)
            for(int i = 0;i < 10 ; i++)
            {
                for (int j = 0; j < 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0;j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //별 피라미드(3)
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //별 피라미드(4)
            for(int i = 0; i < 8 ; i++)
            {
                for (int j = 7; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for(int j = 0;j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}
