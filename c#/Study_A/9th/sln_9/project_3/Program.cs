using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3
{
    internal class Program
    {
        // ➌ 서로 다른 파일에 클래스 생성 --> 호출로 사용
        static void Main(string[] args)
        {
            // 객체생성 -> 호출 -> 변수출력
            Cat kitty = new Cat("키티", "하얀색");
            kitty.Meow();
            Console.WriteLine("{0} : {1}", kitty.Name, kitty.Color);
            Console.WriteLine();

            Cat nero = new Cat("네로", "검정색");
            nero.Meow();
            Console.WriteLine("{0} : {1}", nero.Name, nero.Color);
            Console.WriteLine();

        }
    }
}
