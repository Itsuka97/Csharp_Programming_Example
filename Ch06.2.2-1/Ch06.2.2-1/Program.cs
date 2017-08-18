/* 가변 문자열 타입 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch06._2._2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello World";

            StringBuilder sb = new StringBuilder();
            sb.Append(text);

            for (int i = 0; i < 300000; i++)
            {
                sb.Append("1");
            }

            string newText = sb.ToString();
        }
    }
}
