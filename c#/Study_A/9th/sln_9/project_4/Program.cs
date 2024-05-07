using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace project_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 랜덤 난수 메서드
            Random rand = new Random();
            Console.WriteLine(rand.Next());
            Console.WriteLine(rand.Next(10));
            Console.WriteLine(rand.Next(9, 10));
            Console.WriteLine(rand.NextDouble()*10);

            // 배열 생성
            int[] intArray = new int[3] { 10, 20, 30 };
            string[] stringArray = new string[3] { "aa", "aa", "aa" };
            foreach(var item in intArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Length : "+stringArray.Length);

            // List 클래스
            // List 클래스의 인스턴스 생성
            List<int> list = new List<int>();
            list.Add(456);
            list.Add(789);
            list.Insert(list.Count-2, 123);
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("list.Count --> " + list.Count);

            List<int> list2 = new List<int>() {11, 22, 33, 44};
            foreach(var item in list2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("list2.Count --> "+list2.Count);

            // Math 클래스
            Console.WriteLine("< Math 클래스 >");
            Console.WriteLine(Math.Abs(-52334));   // 절대값
            Console.WriteLine(Math.Ceiling(42.9)); // 정수로 올림
            Console.WriteLine(Math.Floor(42.9));   // 내림
            Console.WriteLine(Math.Round(42.4));   // 반올림
            Console.WriteLine(Math.Max(56,57));
            Console.WriteLine(Math.PI);
        }
    }
}
