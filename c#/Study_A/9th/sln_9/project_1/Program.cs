using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    // 9주 --> **class 생성위치
    // ➊ 하나의 파일에 여러 개의 클래스 생성(클래스 외부)
    class Cat
    {
        public String Name;
        public String Color;
        
        public Cat(String name, String color) // 생성자 선언
        {
            this.Name = name;
            this.Color = color;
        }
        public void Meow() // 메서드
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 객체생성 -> 호출 -> 변수출력
            Cat kitty = new Cat("키티","하얀색");
            kitty.Meow();
            Console.WriteLine("{0} : {1}",kitty.Name, kitty.Color);
            Console.WriteLine();

            Cat nero = new Cat("네로", "검정색");
            nero.Meow();
            Console.WriteLine("{0} : {1}", nero.Name, nero.Color);
            Console.WriteLine();

        }
    }
}
