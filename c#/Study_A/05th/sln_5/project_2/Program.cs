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
            //논리 연산자의 조건문
            Console.WriteLine("학점 입력: ");
            double score = double.Parse(Console.ReadLine());
            if(score == 4.5) { Console.WriteLine("최우수"); }
            else if (4.0 <= score && score < 4.5) {Console.WriteLine("우수"); }
            else if (3.5 <= score && score < 4.0) { Console.WriteLine("아주 잘함"); }
            else if (3.0 <= score && score < 4.5) { Console.WriteLine("잘함"); }
            else if (2.5 <= score && score < 4.5) { Console.WriteLine("보통 잘함"); }
            else if (2.0 <= score && score < 4.5) { Console.WriteLine("보통"); }
            else if (1.5 <= score && score < 2.0) { Console.WriteLine("분발"); }
            else if (1.0 <= score && score < 1.5) { Console.WriteLine("많이 분발"); }
            else { Console.WriteLine("다음 학기에 만나요~"); }

            //조건문 간단히 사용
            //if 조건문은 이전에 비교했던 것이 자동으로 걸러지므로
            // 이전에 비교했던 것을 다시 비교할 필요가 없다.
            if (score == 4.5) { Console.WriteLine("최우수"); }
            else if (4.0 <= score) { Console.WriteLine("우수"); }
            else if (3.5 <= score) { Console.WriteLine("아주 잘함"); }
            else if (3.0 <= score) { Console.WriteLine("잘함"); }
            else if (2.5 <= score) { Console.WriteLine("보통 잘함"); }
            else if (2.0 <= score) { Console.WriteLine("보통"); }
            else if (1.5 <= score) { Console.WriteLine("분발"); }
            else if (1.0 <= score) { Console.WriteLine("많이 분발"); }
            else { Console.WriteLine("다음 학기에 만나요~"); }



        }
    }
}
