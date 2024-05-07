using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3
{
    // ➌ 서로 다른 파일에 클래스 생성
    internal class Cat
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
}
