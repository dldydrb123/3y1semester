using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // break 키워드를 사용하지 않는 switch 조건문
            Console.WriteLine("이번 달은 몇 월인가요? : ");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울입니다."); 
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄입니다.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("summer~");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("fall~");
                    break;

                default:
                    Console.WriteLine("어느 행성..?");
                    break;
            }

            if(input == 12 || input == 1 || input == 2)
            {
                Console.WriteLine("겨울입니다");
            }
            else if(input >= 3 && input <= 5)
            {
                Console.WriteLine("봄입니다");
            }
            else if(input >= 6 && input <= 8)
            {
                Console.WriteLine("summer~");
            }
            else if(input >= 9 && input <= 11)
            {
                Console.WriteLine("fall~");
            }

            // 같은데 관계형 패턴으로 구현 --> https://www.sysnet.pe.kr/2/0/12033
            string season = input switch
            {
                12 or 1 or 2 => "겨울입니다",
                >= 3 and <= 5 => "봄입니다",
                >= 6 and <= 8 => "summer~",
                >= 9 and <= 11 => "fall~",
                _ => "잘못된 입력입니다."
            };

            Console.WriteLine(season);
        }
    }
}
