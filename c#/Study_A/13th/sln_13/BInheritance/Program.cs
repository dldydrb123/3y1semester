using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //상속 : 클래스 구현 부분의 코드 중복을 해결
            //유산을 물려줄 클래스 : 기반 클래스, 부모 클래스
            //물려받는 클래스 : 파생 클래스, 자식 클래스
            //this : 객체 자신을 지칭하는 키워드
            //this() : 자기 자신의 생성자
            //base() : 기반 클래스의 생성자

            List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };

            foreach (var item in Dogs)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
            }
            Console.WriteLine();

            foreach (var item in Cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();
            }
            Console.WriteLine();
        }
    }
}
