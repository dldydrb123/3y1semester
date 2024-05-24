using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class Program
    {
        class MyMath
        {
            public static int Abs(int input) // 클래스 메서드
            {
                if (input < 0) { return -input; }
                else { return input; }
            }

            public static double Abs(double input) // 클래스 메서드
            {
                if (input < 0) { return -input; }
                else { return input; }
            }

            public static long Abs(long input) // 클래스 메서드
            {
                if (input < 0) { return -input; }
                else { return input; }
            }

        }


        static void Main(string[] args)
        {
            //같은 이름의 메서드가 있을 수 있다.
            //이름과 매개변수를 갖고 프로토타입 결정(코드 기본 모델)
            //메서드 오버로딩은 하나의 메서드 이름에 여러개의
            //구현을 올리는것을 뜻한다.

            //int
            Console.WriteLine(MyMath.Abs(50));
            //double
            Console.WriteLine(MyMath.Abs(52.233));
            //long
            Console.WriteLine(MyMath.Abs(214748366470));
            Console.WriteLine();

            Console.WriteLine(MainApp.Plus(1,2));
            Console.WriteLine(MainApp.Plus(1, 2, 3));
            Console.WriteLine(MainApp.Plus(1.0, 2.4));
            Console.WriteLine(MainApp.Plus(1, 2.4));





        }
    }
}
