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
            public string name;
            public int price;
        }
        static void Main(string[] args)
        {
            Product product = new Product();

            product.name = "감자";
            product.price = 5000;
            Console.WriteLine(product.name + " : " + product.price + "원");
            Console.WriteLine();

            Product productA = new Product() { name = "감  자", price = 5000};
            Product productB = new Product() { name = "고구마", price = 6000};
            Product productC = new Product() { name = "호  박", price = 4000};

            Console.WriteLine($"{productA.name} : {productA.price}원");
            Console.WriteLine($"{productB.name} : {productB.price}원");
            Console.WriteLine($"{productC.name} : {productC.price}원");
        }
    }
}
