using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // 배열 : 같은 데이터 타입을 가진 데이터 집합(고정)
            int[] alphas = new int[3] { 10, 20, 30 };
            foreach (var item in alphas) 
            {
                Console.WriteLine(item); 
            }
            Console.WriteLine("======");

            // 리스트 : 같은 데이터 타입을 가진 데이터들의 집합(가변)
            List<int> lists = new List<int>() { 15, 25, 35 };
            lists.Add(45);
            lists.Add(55);

            lists.Remove(lists[2]); // 값 지우기

            lists.Insert(0, 5);     // 중간에 값 삽입

            foreach (var item in lists)
            {
                Console.WriteLine(item);
            }
            */

            // 리스트 응용
            List<int> list = new List<int>();
            for(int i = 0; i < 5; i++)
            {
                list.Add(i);
            }
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            list.RemoveAt(2); // RemoveAt는 List의 지정한 index 값 삭제
            list.Insert(list.Count - 1, 0);

            // ArrayList : 배열과 달리 컬렉션을 생성할 때 용량을 미리 지정할 필요 없이 자동으로 증감함
            // (!!) 데이터 형이 없음
            ArrayList lists = new ArrayList();
            lists.Add(10);
            lists.Add(20);
            lists.Add(30);
            lists.Add(40);
            lists.Add("문자열도 가능");
            lists.RemoveAt(lists.Count - 2); // index[3]
            foreach(var item in lists)
            {
                Console.WriteLine(item);
            }
            
            

        }
    }
}
