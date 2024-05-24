using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class BoxB
    {
        //캡슐화
        //다른 사람이 변수 width와 height를 건드리지 못하게 코드 수정
        //private : 클래스 내부에서만 접근 가능
        private int width; 
        private int height;

        public int Area()
        {
            return this.width * this.height;
        }
        public BoxB(int width, int height) //생성자
        {
            if(width > 0 && height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                Console.WriteLine("너비와 높이를 자연수로 초기화 해주세요.");
            }
        }




    }
}
