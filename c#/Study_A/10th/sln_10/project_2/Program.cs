using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
        class Test
        {
            // 인스턴스 메서드 생성과 사용
            public int Power(int x)
            {
                return x * x;
            }
        }

        class Calcurator
        {
            // 두 개의 매개변수를 갖는 메서드
            public static int Plus(int a, int b)
            {
                return a + b;
            }
            public static int Minus(int a, int b)
            {
                return a - b;
            }
        }

        class MyMath
        {
            public static int Abs(int input)
            {
                if (input < 0) { return -input; }
                else { return input; }
            }
        }

        static void Main(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.Power(10)); // 인스턴스 메서드
            Console.WriteLine(test.Power(20));
            // Console.WriteLine(Test.Power(30));

            int resultA = Calcurator.Plus(3, 4);
            Console.WriteLine(resultA);
            Console.WriteLine(Calcurator.Plus(3, 4));
            int resultB = Calcurator.Minus(5, 2);
            Console.WriteLine(resultB);

            //MyMath myMath = new MyMath();
            //Console.WriteLine(myMath.Abs(-52));
            Console.WriteLine(MyMath.Abs(-52));
            Console.WriteLine(MyMath.Abs(resultA));
            Console.WriteLine(MyMath.Abs(Calcurator.Plus(resultB, resultA)));
        }
    }
}
