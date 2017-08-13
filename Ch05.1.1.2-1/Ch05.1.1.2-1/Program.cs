/* 지역 변수의 유효 범위 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch05._1._1._2_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // 변수가 선언된 블록이 닫히고 나서 그 변수에 접근하려 하는 것은 컴파일 오류
            if (true)
            {
                int i = 5;
            }
            Console.Write(i);       // error: 'i'이름이 현재 컨텍스트에 없습니다.


            // 부모 블록은 자식 블록의 유효범위를 포함하기때문에 컴파일 오류 발생
            int i = 5;
            {
                int i = 10;         // error: 'i'라는 지역 변수는 'i'에 다른 의미를 주기 때문에
                                    // 이 범위에 선언할 수 없습니다. 이 변수는 이미 부모 또는
                                    // 현재 범위에서 다른 의미를 나타내도록 사용되었습니다.
            }


            // 같은 수준의 블록에서는 서로의 유효 범위를 넘지 않으므로 오류 X
            {
                int j = 5;
            }
            {
                int j = 10;
            }
        }
    }
}
