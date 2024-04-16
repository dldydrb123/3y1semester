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
            //문자열 서식
            //서식이라는 것은 문자열이 일정한 틀과 모양을 갖추는 것을 의미한다.
            //Console.WriteLine(); -> 문자열을 출력하는 메서드

            //C#은 문자열 서식화에 사용할 수 있는 간편한 방법 두 가지를 제공한다.
            //ⓛ 첫 번째는 string 형식의 Format() 메서드이고,
            //   문자열 틀을 입력하고, 문자열 틀안에 집어 넣을 데이터를 차례로 입력
            //② 두 번째는 "문자열 보관(interpolation)"이다. 
            //   서식 항목에 첨자 대신 식이 들어간다.

            Console.WriteLine("학과 : " + "컴소과 " + "3학년"); //문자열 연결 연산자
            Console.WriteLine("학과 : {0} {1}", "컴소과", "3학년"); //string 형식의 Format() 메서드
            Console.WriteLine($"학과 : {"컴소과"} {"3학년"}"); //문자열 보관

            Console.WriteLine("{0}, {1}", 123, "최강 컴소과"); //string 형식의 Format() 메서드
            Console.WriteLine($"{123}, {"최강 컴소과"}"); //문자열 보관

            //문자열 틀에 입력하는 {0}, {1}...를 서식 항목이라 한다.
            //{첨자, 맞춤:서식문자열}
            Console.WriteLine("Total : {0, -7:D}", 123);
            Console.WriteLine($"Total : {123, -7:D}");

            Console.WriteLine("Total : {0, 7:D}", 123);
            Console.WriteLine("Total : {0, 7:x}", 123);

            string fmt = "{0, -20}{1, -15}{2, 30}";
            Console.WriteLine(fmt, "Publisher", "Author", "Title");





        }
    }
}
