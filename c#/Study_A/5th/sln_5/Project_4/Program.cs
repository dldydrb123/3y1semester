using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score1 = 80;
            int score2 = 90;
            int score3 = 85;
            int average = (score1 + score2 + score3) / 3;
            Console.WriteLine("average : {0}",average); // 일반적 변수 출력
            Console.WriteLine($"average : {average}"); //문자열 보관
        }
    }
}
