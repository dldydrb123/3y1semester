using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //속성(Property) : 해당 객체의 특징
            //속성은 기본적으로 변수처럼 값을 담는 역할을 하지만 그 값의 객체와 연간이 있다.
            //속성은 객체의 데이터를 저장한다.

            BoxD boxD = new BoxD(-10, 10);
            Console.WriteLine(boxD.Area());
            boxD.Width = 10;
            boxD.Height = 20;
            Console.WriteLine(boxD.Area());
            Console.WriteLine();

            BoxE boxE = new BoxE(-10, 10);
            Console.WriteLine(20);
            boxE.Width = 10;
            boxE.Height = 20;
            Console.WriteLine(boxE.Area());
            Console.WriteLine();



        }
    }
}
