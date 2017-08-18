/* 문자열 관련 타입 */
/* 문자열의 "==" 비교 연산자는 대소문자를 무시하는 기능은 없지만
 * 대신 Equals 메소드로 바꾸면 가능하다. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch06._2._1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello";

            Console.WriteLine(text + " == HELLO: " + (text == "HELLO"));    // 출력 결과: False
            Console.WriteLine(text + " == HELLO: " + text.Equals("HELLO", StringComparison.OrdinalIgnoreCase)); // 출력 결과: True
            Console.WriteLine();
        }
    }
}
