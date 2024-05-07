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
            Book book = new Book();
            // 인스턴스는 일반 변수와 동일하게 
            // 1. 값을 할당하는 일과 2. 추출해서 확인하는 일 모두 가능

            book.title = "ㄸㅃㅇ가 먹고싶어";
            book.writer = "유산슬";
            book.content = "ㄸㅂㅇ는 언제 먹어도 맛있어";
            book.publisher = "도서출판 분식집";
            book.published_date = 20240507;

            // ➊ 단순할당 and 단순출력
            Console.WriteLine("제목 --> "+book.title);
            Console.WriteLine("저자 --> "+book.writer);
            Console.WriteLine("내용 --> "+book.content);
            Console.WriteLine("출판사 --> "+book.publisher);
            Console.WriteLine("출판일 --> "+book.published_date);

            // ➋ 선언과 동시에 할당
            // Product product = new Product("aa",34); 
            Product productA = new Product() { name = "감자", price = 3000 };
            Product productB = new Product() { name = "고구마", price = 6000 };
            Product productC = new Product() { name = "당근", price = 500 };

            Console.WriteLine($"{productA.name} --> {productA.price}");
            Console.WriteLine($"{productB.name} --> {productB.price}");
            Console.WriteLine($"{productC.name} --> {productC.price}");

            // 클래스 변수란? 클래스 이름을 사용해 바로 변수와 메서드를 사용할 수 있다
            // 클래스 변수와 클래스 메서드를 만들때는 static 키워드를 사용한다
            // ➌ static을 사용해 인스턴스 생성 없이 바로 클래스 변수에 접근

            MyMath mymath = new MyMath();
            Console.WriteLine($"{mymath.PI}");

            Car car = new Car();
            car.Hi();
            car.Go();
           


        }
    }
}   
