using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3
{
    //③ 서로 다른 파일에 클래스 생성
    internal class Program
    {
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
