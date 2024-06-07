using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class BoxD
    {
        //일반적인 속성 생성 방법
        //get 접근자와 set 접근자를 사용하여 속성 선언
        //get 접근자는 필드를 읽어오고(추출) set 접근자는 필드에 값을 할당(저장)
        //set 접근자 안에 value 키워드는 누구도 선언한 적 없지만 C# 컴파일러는 set 접근자의 암묵적 매개변수로 간주한다.
        private int width; //인스턴스 변수(필드)
        public int Width  //속성
        {
            get { return width; }
            set 
            { 
                if(width > 0) {  width = value; }
                else { Console.WriteLine("너비는 자연수를 입력해주세요"); }
            }
        }
        private int height;
        public int Height
         {
            get { return height; }
            set
            {
                if (height > 0) { height = value; }
                else { Console.WriteLine("높이는 자연수를 입력해주세요"); }
            }
        }
        public int Area() //인스턴스 메서드
        {
            //return this.width * this.height;
            return Width * Height;
        }
        public BoxD(int width, int height) //생성자
        {
            Width = width;
            Height = height;
        }
    }
}
