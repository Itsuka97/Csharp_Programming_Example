/* 사용자 정의 특성(Attribute) */
/* 특성은 프로그램의 흐름에 직접적인 영향은 끼치지 않으면서 
 개발자로 하여금 정보를 남기는 주석과 같은 기능을 한다.
 특성 정보는 컴파일된 결과물에도 남아 있다.
 Reflection과 결합되면 응용 범위가 확장된다.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch05._1._1._4_1
{
    [type: Author(name: "KangSangYeon", version: 1)]
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
