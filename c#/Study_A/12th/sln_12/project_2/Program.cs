using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
        class Parent 
        {
            public Parent() 
            {
                Console.WriteLine("부모(기반) 생성자");
            }
        }

        class Child : Parent
        {
            public Child()
            {
                Console.WriteLine("자식(파생) 생성자");
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
