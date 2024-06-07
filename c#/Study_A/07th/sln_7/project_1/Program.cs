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
            //Lenth 속성
            //배열은 Length 속성으로 배열의 길이를 구한다.
            int[] intArray = { 52, 273, 32, 65, 103 };
            Console.WriteLine(intArray.Length);

            //배열의 범위를 벗어나는 인덱스 접근
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[4]);
            //Console.WriteLine(intArray[5]); //배열의 범위를 벗어남
            Console.WriteLine();

            //무한 반복
            //for문
            /*
            for (; ; )
            {
                Console.WriteLine("무한반복");

            while (true)
            {
                Console.WriteLine("무한반복");
            }
            */

            int i = 0;
            Console.WriteLine("\"while 반복문\"");
            Console.WriteLine();

            while (i < intArray.Length)
            {
                Console.WriteLine(i + "번째 출력 : " + intArray[i]);
                Console.WriteLine($"{i + 1}번째 출력 : {intArray[i]}");
                Console.WriteLine("{0}번째 출력 : {1}", i +1, intArray[i]);
                i++;

            }
            Console.WriteLine();

            for (i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(i + "번째 출력 : " + intArray[i]);
            }
            Console.WriteLine();

            //do while 반복문 
            //문장은 한번은 꼭 실행해야 하는 특수한 목적에만 사용한다.
            string input;
            do
            {
                Console.WriteLine("exit를 입력하면 종료 : ");
                input = Console.ReadLine();
            } while (input !="exit");
            Console.WriteLine();

            //for 반복문으로 덧셈하기
            int output = 0;
            for (i = 0; i <= 100;i++)
            {
                output += i;
            }
            Console.WriteLine(output);
            Console.WriteLine();

            //for 반복문으로 곱셈하기
            output = 1;
            for(i = 1; i <= 10; i++)
            {
                output *= i;
            }
            Console.WriteLine(output);
            Console.WriteLine();

            //역 for 반복문
            int[] intArray2 = { 10, 20, 30, 40, 50, 60 };
            for (i = intArray2.Length - 1; i >= 0 ; i--)
            {
                Console.WriteLine(intArray2[i]);
            }
            Console.WriteLine();

            //foreach 반복문과 var 키워드
            string[] array = { "사과", "배", "포도", "딸기", "바나나", "수박"};
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            




        }
    }
}
