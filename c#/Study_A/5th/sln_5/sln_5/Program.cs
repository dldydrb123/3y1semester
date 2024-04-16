using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sln_5
{
    internal class Program
    {
        static void Main(string[] args)
            // ① 조건문 --> if-else / switch
            // ② 중첩 조건문
            // ③ if-if-if-else문의 의미
            // ④⑤⑥
        {/*
            // 조건문
            Console.Write("숫자 입력 : ");
            int input = int.Parse(Console.ReadLine()); // 입력 --> parse --> int 변환

            // #1
            if(input % 2 == 0) {
                Console.WriteLine("짝수");
            } else {
                Console.WriteLine("홀수");
            }

            // #2
            switch (input % 2) {
                case 0:
                    Console.WriteLine("짝수");
                    break;
                case 1:
                    Console.WriteLine("홀수");
                    break;
            } 

            // 중첩 조건문  
            // if - else(if else) 구조
            if (DateTime.Now.Hour < 11) {
                Console.WriteLine("아침 시간");
            } else {
                if (DateTime.Now.Hour < 15) {
                    Console.WriteLine("점심 시간");
                } else {
                    Console.WriteLine("저녁 시간");
                }
            }

            // if - else if - else 구조
            if (DateTime.Now.Minute < 20) {
                Console.WriteLine("20분 이전");
            } else if (DateTime.Now.Minute < 40) {
                Console.WriteLine("40분 이전");
            } else {
                Console.WriteLine("이후");
            } */

            // 의도에 따라 선택
            Console.Write("금액을 입력 : ");
            int money = int.Parse(Console.ReadLine());
            if (money >= 20000) Console.WriteLine("탕수육");
            if (money >= 10000) Console.WriteLine("쟁반짜장");
            else Console.WriteLine("단무지");


            if (money >= 20000) Console.WriteLine("탕수육");
            else if (money >= 10000) Console.WriteLine("쟁반짜장");
            else Console.WriteLine("단무지");



        }
    }
}
