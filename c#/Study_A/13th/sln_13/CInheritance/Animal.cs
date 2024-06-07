using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BInheritance
{
    internal class Animal
    {
        public int Age { get; set; }
        public Animal() { this.Age = 0; } //this : 객체 자신을 지칭하느 키워드

        public void Eat() { Console.WriteLine("뇸뇸"); }
        public void Sleep() { Console.WriteLine("쿨쿨"); }

    }
}
