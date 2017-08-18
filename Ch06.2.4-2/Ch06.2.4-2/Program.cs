/* 정규표현식 타입 System.Text.RegularExpressions.Regex */
/* string 타입의 Replace 메소드는 아쉽게도 대소문자가 구분되어 동작한다.
 * 정규표현식을 이용하면 쉽게 대소문자를 구분하지 않은 Replace 를 이용할 수 있다. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Ch06._2._4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, World! Welcome to my world!";

            Regex regex = new Regex("world", RegexOptions.IgnoreCase);
            string result = regex.Replace(text, funcMatch);

            Console.WriteLine(result);  // 출력 결과: Hello, Universe! Welcome to my Universe!
        }

        static string funcMatch(Match match)
        {
            return "Universe";
        }
    }
}
