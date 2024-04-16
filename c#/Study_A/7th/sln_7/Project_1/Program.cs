using System;

namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //------------배열, 반복문, foreach와 var관계------------
            // 1. 배열복습
            // Length 속성 : 배열은 Length 속성으로 배열의 길이를 구한다
            int[] intArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine(intArray.Length);

            // 배열의 범위를 벗어나는 인덱스 접근 3+1을 3+2로 바꾸면 나가져서 
            // index out of range 버그 발생
            Console.WriteLine(intArray[(int)3+1]);

            // 2. 배열 + 반복문 **셤문제
            int i = 0;
            int[] intArrayTwo = {52,34,36,102,42};
            Console.WriteLine("\"while 반복문\"");
            Console.WriteLine();

            while(i < intArrayTwo.Length)
            {
                Console.WriteLine(i+"번째 출력 : " + intArrayTwo[i]);
                i++;
            }

            for (i = 0; i < intArrayTwo.Length; i++)
            {
                Console.WriteLine(i + "번째 출력 : " + intArrayTwo[i]);
            }

            // 3. do-while 반복문
            // 문장을 한 번은 꼭 실행해야 하는 특수한 목적에만 사용한다

            string input;
            do
            {
                Console.Write("\n입력 exit를 입력하면 종료 : ");
                input = Console.ReadLine();
            } while (input != "exit");

            // 4. 반복문 응용
            // for 반복문으로 덧셈
            int output = 0;
            for (int j = 0; j <= 100; j++)
            {
                output += j;
            }
            Console.WriteLine(output);
            // for 반복문으로 곱셈
            int multipl = 1;
            for (int k = 1; k <= 20; k++)
            {
                multipl *= k;
            }
            Console.WriteLine(multipl);
            // 역 for 반복문
            int[] intArrayThree = { 10, 20, 30, 40, 50, 60 };
            for (int j = intArrayThree.Length - 1; j >= 0; j--) // 0보다 크거나 같을 떄 까지만 반복
            {
                Console.WriteLine(intArrayThree[j]);
            }

            // 5. foreach 반복문과 var 키워드
            string[] array = { "사과", "배", "포도", "딸기", "바나나" };
            foreach(var item in array) // foreach --> array 원소들을 꺼내서 item에 저장
            { 
                Console.WriteLine(item); 
            }


        }
    }
}
