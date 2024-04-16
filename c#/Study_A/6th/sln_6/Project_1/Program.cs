using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ** 배열 선언 방식 문제 */
            // 배열 사용 첫 번째 방법 --> 하나하나 할당
            int[] scores1 = new int[5];
            scores1[0] = 80;
            scores1[1] = 74;
            scores1[2] = 96;
            scores1[3] = 89;
            scores1[4] = 100;

            // 두 번째 방법(기본) --> 선언과 동시에 초기값 할당
            int[] scores2 = new int[5] { 80, 90, 100, 20, 30 };

            // 세 번째 방법 --> 배열 크기 생략 + 초기값 할당
            int[] scores3 = new int[] { 80, 90, 100 };

            // 네 번째 방법 --> 값만 할당
            int[] scores4 = { 90, 100, 46, 100 };

            // 출력
            foreach (var score in scores1) 
            {
                Console.WriteLine(score);
            }

            int sum = 0;
            foreach (var score in scores2) 
            {
                sum += score;
            }
            Console.WriteLine("sum score-->" + sum);
            int average = sum / scores2.Length;
            Console.WriteLine("average score-->{0}", average); // 문자열 보간

            
   
        }
    }
}
