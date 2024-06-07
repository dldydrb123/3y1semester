using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //배열을 초기화하는 방법
            //첫번째 방법
            int[] scores1 = new int[5];
            scores1[0] = 86;
            scores1[1] = 74;
            scores1[2] = 81;
            scores1[3] = 95;
            scores1[4] = 67;

            //두번째 방법 (가장 기본적인 방식)
            int[] scores2 = new int[5] {86, 74, 81, 95, 67};

            //세번째 방법
            int[] scores3 = new int[] { 86, 74, 81, 95, 67 };

            //네번째 방법
            int[] scores4 = { 86, 74, 81, 95, 67 };

            foreach (var score in scores1)
            {
                Console.WriteLine(score);
            }

            int sum = 0;
            foreach (var score in scores2)
            {
                sum += score;
            }
            Console.WriteLine(sum);
            int average = sum / scores2.Length;
            Console.WriteLine(average);
            Console.WriteLine($"Average Score : {average}");

        }
    }
}
