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
            String hak = "";
            Console.WriteLine("학년 입력 : ");
            hak = Console.ReadLine();

            if (hak == "1학년")
            {
                Console.WriteLine("1호관으로 오세요~");
                Console.WriteLine("베라상품권 증정");
            }

            else
            {
                if (hak == "2학년")
                {
                    Console.WriteLine("2호관으로 오세요~");
                    Console.WriteLine("스벅상품권 증정");
                }

                else
                {
                    Console.WriteLine("3호관으로 오세요~");
                    Console.WriteLine("배민상품권 증정");
                }


            }
            



        }
    }
}
