using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3
{
    internal class MyClassC
    {
        private int myField;  //변수(필드) 이름
        public int MyField  //속성 이름
        {
            get { return myField; }
            set { myField = value; } 
        }
    }
}
