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
            //조건문
            Console.WriteLine("숫자 입력:");
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0) { Console.WriteLine("짝수입니다."); }
            if (input % 2 == 1) { Console.WriteLine("홀수입니다."); }
            Console.WriteLine();

            if (input % 2 == 0) { Console.WriteLine("짝수입니다."); }
            else { Console.WriteLine("홀수입니다."); }
            Console.WriteLine();
            
            switch(input % 2)
            {
                case 0: 
                    Console.WriteLine("짝수");
                    break;
                case 1: 
                    Console.WriteLine("홀수");
                    break;
            }



            //중첩 조건문
            if (DateTime.Now.Hour < 11) 
            {
                Console.WriteLine("아침을 먹을 시간입니다.");
            }
            else
            {
                if (DateTime.Now.Hour < 15)
                {
                    Console.WriteLine("점심을 먹을 시간입니다.");
                }
                else
                {
                    Console.WriteLine("저녁을 먹을 시간입니다.");
                }
            }
            
            //if else if 조건문
            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침을 먹을 시간입니다.");
            }
            else if(DateTime.Now.Hour < 15)
            {
                Console.WriteLine("점심을 먹을 시간입니다.");
            }
            else
            {
                Console.WriteLine("저녁을 먹을 시간입니다.");
            }


            Console.WriteLine("금액을 입력하세요.");
            int money = int.Parse(Console.ReadLine());

            if (money >= 20000) Console.WriteLine("탕수육");
            if (money >= 10000) Console.WriteLine("쟁반짜장");
            if (money >= 8000) Console.WriteLine("잠뽕");
            if (money >= 7000) Console.WriteLine("짜장면");
            else Console.WriteLine("단무지");
            Console.WriteLine();
            Console.WriteLine();

            if (money >= 20000) Console.WriteLine("탕수육");
            else if (money >= 10000) Console.WriteLine("쟁반짜장");
            else if (money >= 8000) Console.WriteLine("잠뽕");
            else if (money >= 7000) Console.WriteLine("짜장면");
            else Console.WriteLine("단무지");

        }
    }
}
