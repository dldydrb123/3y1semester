using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class BoxA
    {
        //너비와 높이를 변수로 갖고, 이를 기반으로 사각형의 넓이를 구하는 클래스
        public int width; //인스턴스 변수(필드)
        public int height;
        public int Area() //인스턴스 메서드
        {
            return this.width * this.height;
        }
        public BoxA(int width, int height) //생성자
        {
            this.width = width;
            this.height = height;
        }






    }
}
