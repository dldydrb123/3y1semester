using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine(rand.Next());
            Console.WriteLine(rand.Next());
            Console.WriteLine(rand.Next(10));
            Console.WriteLine(rand.Next(10));
            Console.WriteLine(rand.Next(0,100));
            Console.WriteLine(rand.NextDouble());
            Console.WriteLine(rand.NextDouble() * 10);
            Console.WriteLine();

            //배열 생성
            int[] intArray = new int[3] { 10, 20, 30 };
            long[] longArray = new long[3] { 101, 102, 103 };
            string[] stringArray = new string[3] { "사과", "딸기", "참외" };

            foreach (int item in intArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            foreach (var item in longArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            foreach (var item in stringArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Length :" + stringArray.Length);
            Console.WriteLine();

            //List 클래스
            //List 클래스의 인스턴스 생성

            List<int> list = new List<int>();

            //리스트에 요소 추가
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Remove(20);
            list.RemoveAt(0);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //List 인스턴스 생성과 동시에 요소 추가
            List<int> list1 = new List<int> { 52, 273, 32, 64 };
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count : " + list1.Count);
            Console.WriteLine();

            //Math 클래스
            Console.WriteLine(Math.Abs(-52273));
            Console.WriteLine(Math.Ceiling(52.273));
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Round(52.273));
            Console.WriteLine(Math.Max(52,273));
            Console.WriteLine(Math.Min(52,273));
            Console.WriteLine(Math.PI);
        }
    }
}
