using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //break 키워드를 사용하지 않는 switch 조건문
            Console.WriteLine("이번 달은 몇월인가요? : ");
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
                    Console.WriteLine("여릅입니다.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을입니다.");
                    break;
                default:
                    Console.WriteLine("어느 행성에서 오셨나요~");
                    break;

            }
            Console.WriteLine();

            // if else if 조건문 (논리 연산자 사용)

            if (input == 12 || input == 1 || input == 2) { Console.WriteLine("겨울입니다."); }
            else if (input == 3 || input == 4 || input == 5) { Console.WriteLine("봄입니다."); }
            else if (input == 6 || input == 7 || input == 8) { Console.WriteLine("여름입니다."); }
            else if (input == 9 || input == 10 || input == 11) { Console.WriteLine("가을입니다."); }
            else { Console.WriteLine("어느 행성에서 오셨나요~"); }
            Console.WriteLine();

            //AND 조건

            if (input == 12 || input >= 1 && input <= 2) { Console.WriteLine("겨울입니다."); }
            else if (input >= 3 && input <= 5) { Console.WriteLine("봄입니다."); }
            else if (input >= 6 && input <= 8) { Console.WriteLine("여름입니다."); }
            else if (input >= 9 && input <= 11) { Console.WriteLine("가을입니다."); }
            else { Console.WriteLine("어느 행성에서 오셨나요~"); }
            Console.WriteLine();





        }
    }
}
