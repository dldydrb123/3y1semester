using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
        //② 클래스 내부에 클래스 생성
        class Cat
        {
            public string Name;
            public string Color;
            public Cat(string name, string color) //생성자 정의(선언)
            {
                Name = name;
                Color = color;
            }
            public void Meow() //메서드
            {
                Console.WriteLine($"{Name} : 야옹~");
            }
        }
        static void Main(string[] args)
        {
            Cat Kitty = new Cat("키티", "하얀색");
            Kitty.Meow();
            Console.WriteLine("{0} : {1}", Kitty.Name, Kitty.Color);
            Console.WriteLine();
            Cat nero = new Cat("네로", "검은색");
            nero.Meow();
            Console.WriteLine("{0} : {1}", nero.Name, nero.Color);
        }
    }
}
