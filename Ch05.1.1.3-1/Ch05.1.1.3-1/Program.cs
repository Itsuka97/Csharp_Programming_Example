/* 리터럴에도 적용되는 타입 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch05._1._1._3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 리터럴을 통해서도 System.Int32 타입 멤버를 사용 가능
            Console.WriteLine(5.ToString() + 6.ToString());     // 출력 결과: 56

            // 문자열도 string타입의 인스턴스로 취급되어 다음과 같은 호출 가능
            Console.WriteLine("test".ToUpper());
        }
    }
}
