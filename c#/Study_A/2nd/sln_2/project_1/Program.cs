using System;
using static System.Console;
// using : namespace에서 참조하겠다는 뜻
// ** static : 정적, 전역변수를 사용할 때 사용



namespace project_1
{
    internal class Program 
    {
        static void Main(string[] args) // ** static 사용이유 : 메모리 공간을 미리 확보, 처음부터 메모리 공간을 확보
        {
            System.Console.WriteLine(929);
            Console.WriteLine(929);
            WriteLine(929);

            System.Console.Write(929);
            Console.Write(929);
            Write(929);
            WriteLine("C# Programming");

            WriteLine(4 % 3);
            WriteLine("A");
            WriteLine('A'+"B");
            WriteLine('A' + 'B');

            // escape 이스케이프 문자
            WriteLine("컴퓨터\t소프트웨어\n공학과");

            // 문자 선택
            WriteLine("안녕하세요."[0]);

            // 참과 거짓
            WriteLine(52 == 273);
            WriteLine(929.30 == 929.3);

            // 시간
            WriteLine(DateTime.Now.Hour < 14 && 8 < DateTime.Now.Hour);

            int a = 23;
            char c = 'a'; // ASCII CODE
            WriteLine(c+'b'+(c * 5));

            // var은 입력값에 따라 데이터형 결정
            var g = 10;


        }
    }
}
