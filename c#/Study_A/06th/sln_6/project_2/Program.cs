using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //배열 : 같은 데이터 타입을 가진 데이터 집합(고정)
            int[] alphas = new int[3] {10, 20, 30};
            foreach (var item in alphas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //리스트 : 같은 데이터 타입을 가진 데이터들의 집합(가변)
            List<int> lists = new List<int>() { 15, 25, 35};
            lists.Add(45);
            lists.Add(55);
            foreach (var item in lists)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            lists.Remove(50);
            lists.RemoveAt(4);
            lists.Insert(0, 5);
            foreach (var item in lists)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            List<int> list = new List<int>();
            for (int i = 10; i < 16; i++)
            {
                list.Add(i);
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            
            list.RemoveAt(2);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            list.Insert(2,2);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //ArrayList : 배열과 달리 컬렉션을 생성할 때 용량을 미리 지정할 필요없이 필요에 따라 자동으로 그 용량이 늘어나거나 줄어든다.

            ArrayList lists2 = new ArrayList();
            lists2.Add(10);
            lists2.Add(20);
            lists2.Add(30);
            lists2.Add(40);
            lists2.Add(50);

            foreach (var item in lists2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            lists2.Remove(30);
            lists2.RemoveAt(2);
            lists2.Insert(2, 25);
            foreach (var item in lists2)
            {
                Console.WriteLine(item);
            }

        }
    }
}
