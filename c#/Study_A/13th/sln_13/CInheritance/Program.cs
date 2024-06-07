using BInheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //다형성 : 코드의 중복을 해결
            //하나의 클래스가 여러 형태로 변환될 수 있는 성질
            //자식 클래스가 부모 클래스로 위장하는 것
            //기반 클래스와 파생 클래스 사이의 형식 변환(is, as)
            //C#은 형변환을 위해 멋진 연산자 두 개를 제공한다.
            //is 키워드 : 객체가 해당 형식에 해당하는지를 검사하여 그 결과를 bool 값으로 반환
            // → 반환을 실패하는 경우 예외를 던진다.
            //as 키워드 : 형식변환 연산자와 같은 역할을 한다.
            // → 반환을 실패하는 경우 객체 참조를 null로 만든다.

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

            //강제 자료형 변환
            var a = 10.01;
            var b = 10.01;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine();


            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Dog(), new Cat(),
                new Dog(), new Cat(), new Dog(), new Cat(),
            };
            Console.WriteLine();

            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();
                //((Dog)item).Bark();
                //((Cat)item).Meow();
                Console.WriteLine();

                //is 키워드를 사용하는 일반적인 형태
                if (item is Dog) { ((Dog)item).Bark(); }
                if (item is Cat) { ((Cat)item).Meow(); }
                Console.WriteLine();

                //as 키워드를 사용하는 자료형 변환
                if (item is Dog) { (item as Dog).Bark(); }
                if (item is Cat) { (item as Cat).Meow(); }
                Console.WriteLine();

                //as 키워드를 사용하는 경우의 일반적인 자료형 변환
                var dog = item as Dog;
                if (dog != null) { dog.Bark(); }
                var cat = item as Cat;
                if (cat != null) { cat.Meow(); }

            }
        }
    }
}
