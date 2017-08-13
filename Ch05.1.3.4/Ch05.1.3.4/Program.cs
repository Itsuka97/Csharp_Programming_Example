/* 안전하지 않은 컨텍스트 unsafe 예약어 */
/* C/C++ 언어와의 호환성을 위해 제공된다. 
 비주얼 스튜디오 환경이라면 프로젝트 속성 창의 "빌드(Build)" 탭에서
 "안전하지 않은 코드 허용(Allow unsafe code)" 옵션을 설정해야 컴파일이 가능하다. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch05._1._3._4
{
    class Program
    {
        unsafe static void GetAddResult(int* p, int a, int b)
        {
            *p = a + b;
        }

        static void Main(string[] args)
        {
            int i;

            unsafe
            {
                GetAddResult(&i, 5, 10);
            }

            Console.WriteLine(i);
        }
    }
}
