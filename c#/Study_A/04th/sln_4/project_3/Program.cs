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
            int jumsu = 0;
            String grade = " ";
            Console.WriteLine("점수 입력:");
            jumsu = int.Parse(Console.ReadLine());
            if(jumsu >= 90) {
                grade = "A";
            }
            else
            {
                if(jumsu >= 80)
                {
                    grade = "B";
                }
                else
                {
                    grade = "F";
                }
            }

            Console.WriteLine("{0}점은 {1}학점입니다.", jumsu, grade);
            Console.WriteLine($"{jumsu}점은 {grade}학점입니다.");
        }
    }
}
