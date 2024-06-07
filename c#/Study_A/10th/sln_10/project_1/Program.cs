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
            // 인스턴스는 일반 변수와 동일하게 값을 할당하는 일과
            // 추출해서 확인하는 일 모두 가능하다.
            // 인스턴스 변수
            book.title = "떡볶이가 먹고싶어";
            book.writer = "유산슬";
            book.content = "떡볶이는 언제 먹어도 맛있어";
            book.publisher = "도서출판 분식집";
            book.published_date = 20240507;

            Console.WriteLine("제목 : "+book.title);
            Console.WriteLine("제목 : {0}", book.title);
            Console.WriteLine($"제목 : {book.title}");
            Console.WriteLine("저자 : " + book.writer);
            Console.WriteLine("내용 : " + book.content);
            Console.WriteLine("출판사 : " + book.publisher);
            Console.WriteLine("출판일 : "+book.published_date);
            Console.WriteLine();

            Product product = new Product();
            product.name = "감자";
            product.price = 2000;
            Console.WriteLine($"{product.name} : {product.price}");
            Console.WriteLine();

            Product productA = new Product() { name = "감  자", price = 5000 };
            Product productB = new Product() { name = "고구마", price = 6000 };
            Product productC = new Product() { name = "당  근", price = 3000 };
            Product productD = new Product() { name = "양  파", price = 4000 };

            Console.WriteLine($"{productA.name} : {productA.price}");
            Console.WriteLine($"{productB.name} : {productB.price}");
            Console.WriteLine($"{productC.name} : {productC.price}");
            Console.WriteLine($"{productD.name} : {productD.price}");
            Console.WriteLine();

            // 클래스 변수
            // 클래스 이름을 사용해서 곧바로 변수와 메서드를 사용할 수 있다.
            // 클래스 변수와 클래스 메서드를 만들 때는 static 키워드를 사용한다.
            Console.WriteLine($"MyMath.PI : {MyMath.PI}");
            Console.WriteLine();

            Car car = new Car();
            car.Hi();
            car.Go();
            Car myCar = new Car();
            myCar.Hi();
            myCar.Go();
        }
    }
}
