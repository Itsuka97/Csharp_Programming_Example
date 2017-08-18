/* 문자열 관련 타입 */
/* Format 메소드의 주된 기능은 인자를 형식 문자열에 포함된 번호와 맞춰서 치환하는 기능이다. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch06._2._1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = string.Format("Hello {0}: {1}", "World", "Anderson");

            Console.WriteLine(output);
        }
    }
}
