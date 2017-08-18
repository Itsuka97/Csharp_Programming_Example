/* 문자열 관련 타입 */
/* {번호[, 정렬][:형식문자열]}
 * 
 * 번호(필수): 숫자 0부터 시작하는 번호를 지정 
 * 
 * 정렬(선택): 번호와 대응되는 문자열의 최소 너비를 지정, 
 * 대응 문자열의 길이는 5인데 정렬로 지정된 숫자가 10이라면 나머지 너비는 공백으로 채워짐.
 * 정렬값이 음수이면 왼쪽, 양수이면 우측 정렬이 된다.
 * 정렬값이 생략되면 대응되는 문자열의 길이대로 출력됨.
 * 
 * 형식문자열(선택): 대응되는 인자의 타입에서 직접 구현하고 있는 형식 문자열이 사용됨.
 * 따라서 Int32, Double 등의 타입에 따라 그에 맞는 형식 문자열을 찾아서 지정.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch06._2._1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "{0, -10} * {1} == {2, 10}";
            Console.WriteLine(text, 5, 6, 5 * 10);
        }
    }
}
