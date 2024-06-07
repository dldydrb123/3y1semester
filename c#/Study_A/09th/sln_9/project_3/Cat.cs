using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3
{
    internal class Cat
    {
        public string Name;
        public string Color;
        public Cat(string name, string color) //생성자 정의(선언)
        {
            Name = name;
            Color = color;
        }
        public void Meow() //메서드
        {
            Console.WriteLine($"{Name} : 야옹~");
        }
    }
}
