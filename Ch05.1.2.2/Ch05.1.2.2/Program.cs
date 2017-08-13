/* 비트 논리 연산자 */
/* 피연산자의 숫자값을 2진수 상태로 비트연산을 수행 
 비트 논리 연산자가 사용되는 대표적인 경우는 각 비트의 값을 특정 상태를 나타내는 의미로 사용할 때다.
 예를 들어, 8비트 부호 없는 정수(byte) 타입은 각 비트에 On/Off로 나타낼 수 있으므로 총 8개의 상태를 저장할 수 있다.
 사실 C#에서는 상태값 처리를 굳이 비트연산으로 하지 않고 [Flags] 특성이 지정된 enum 타입으로 대체하는 것이 일반적 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch05._1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc(0x01, 10, 5);                  // 더하기만 수행
            Calc(0x02 | 0x04 | 0x08, 10, 5);    // 빼기, 곱하기, 나누기를 함께 수행
        }

        public static void Calc(byte op, int operand1, int operand2)
        {
            if((op & 0x01) == 0x01)
            {
                Console.WriteLine(operand1 + operand2);
            }
            if ((op & 0x02) == 0x02)
            {
                Console.WriteLine(operand1 - operand2);
            }
            if ((op & 0x04) == 0x04)
            {
                Console.WriteLine(operand1 * operand2);
            }
            if ((op & 0x08) == 0x08)
            {
                Console.WriteLine(operand1 + operand2);
            }
        }
    }
}
