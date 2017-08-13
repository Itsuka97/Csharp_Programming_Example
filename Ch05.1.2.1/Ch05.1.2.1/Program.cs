/* 시프트 연산자 */
/* 비트 단위로 데이터를 제어할 때 사용.
 * 2진수 상태의 값을 좌/우로 비트를 밀어내는 연산자. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch05._1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 38;                         // 00100110

            int leftShiftedResult = n << 2;     // 10011000
            int rightShiftedResult = n >> 2;    // 00001001

            Console.WriteLine(leftShiftedResult);       // 출력 결과: 152
            Console.WriteLine(rightShiftedResult);      // 출력 결과: 9
        }
    }
}
