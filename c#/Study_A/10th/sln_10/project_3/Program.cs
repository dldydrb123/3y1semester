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
            public string name;
            public int grade;
        }

        static void Main(string[] args)
        {
            /*
            List<Student> list = new List<Student>();
            list.Add(new Student() { name = "홍길동", grade = 1 });
            list.Add(new Student() { name = "유산슬", grade = 2 });
            list.Add(new Student() { name = "강호돌", grade = 2 });

            foreach (var item in list)
            {
                Console.WriteLine(item.name + " : " + item.grade);
            }
            */

            List<Student> list = new List<Student>()
            {
                new Student() {name = "홍길동", grade = 1},
                new Student() {name = "유산슬", grade = 2},
                new Student() {name = "강호돌", grade = 3},
                new Student() {name = "길빛나", grade = 2},
                new Student() {name = "육제이", grade = 1}
            };

            foreach (var item in list)
            {
                Console.WriteLine(item.name + " : " + item.grade);
            }
        }
    }
}
