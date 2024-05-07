using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3
{
    internal class Program
    {
        class Student
        {
            public String name;
            public int grade;

        }
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student() { name = "홍길동", grade = 1} );
            list.Add(new Student() { name = "유산슬", grade = 2 });

            foreach (var item in list)
            {
                Console.WriteLine(item.grade+","+item.name);
            }

            // ➊ 리스트 생성과 동시에 값 할당
            List<Student> list2 = new List<Student>()
            {
                new Student() { name = "홍길동", grade = 1 },
                new Student() { name = "달걀이", grade = 2 }
            };
        }
    }
}
