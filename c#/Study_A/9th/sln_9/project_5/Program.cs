using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5
{
    internal class Program
    {
        class Product
        {
            /* default 값
            public int Id { get; set; } */
            public int price;
            public string name;

        }
        static void Main(string[] args)
        {
            Product product = new Product();
            product.name = "감자";
            product.price = 929;
            Console.WriteLine($"{product.name} : {product.price}");

            // 생성과 동시에 값 할당
            Product productA = new Product() { name = "토마토", price = 929 };
        }
    }
}
