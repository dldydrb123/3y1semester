using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    class Test
    {
        // 인스턴스 메서드 생성과 사용
        public int Power(int x)
        {
            return x * x;
        }
    }

    class Calcurator
    {
        // static 키워드를 사용해 클래스 메서드에 바로 접근 가능하게 함
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }
    
    class MyMath
    {
        public static int Abs(int input)
        {
            if (input < 0) { return -input; }
            else { return input; }
        }
    }

    // Test용
    class InputOutputTest
    {
        public int var1;
        public int var2;
        public List<int> testlist = new List<int>();

        public InputOutputTest(int var1, int var2)
        {
            this.var1 = var1;
            this.var2 = var2;
            testlist.Add(this.var1);
            testlist.Add(var2);
            
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            // Test.Power(929); <-- 에러!
            test.Power(929);
            
            Calcurator.Plus(20, 30);

            // Test용
            InputOutputTest io = new InputOutputTest(929, 1022);
            Console.WriteLine(io.testlist[1]);
        }
    }
}
