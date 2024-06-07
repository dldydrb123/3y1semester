using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClassA obj = new MyClassA();
            obj.myField = 10;
            Console.WriteLine(obj.myField);
            Console.WriteLine();

            MyClassB abc = new MyClassB();
            abc.SetMyField(10);
            Console.WriteLine(abc.GetMyField());
            Console.WriteLine();

            MyClassC space = new MyClassC();
            space.MyField = 10;
            Console.WriteLine(space.MyField);
            Console.WriteLine();

            MyClassD space1 = new MyClassD();
            space1.MyField = 10;
            Console.WriteLine(space1.MyField);
            Console.WriteLine();


        }
    }
}
