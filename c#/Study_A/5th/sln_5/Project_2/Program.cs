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
            // 논리 연산자와 조건문
            Console.WriteLine("학점 입력");
            double score = double.Parse(Console.ReadLine());
            if(score == 4.5) { Console.WriteLine("최우수"); }
            else if(score <= 4.0)
            {

            }

        }
    }
}
