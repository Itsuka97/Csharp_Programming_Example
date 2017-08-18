using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch06._2._1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello World";

            // 대소문자 구분 X: StringComparison.OrdinalIgnoreCase

            Console.WriteLine(text + " EndsWith(\"WORLD\"): " + text.EndsWith("WORLD", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine();

            Console.WriteLine(text + " IndexOf(\"WORLD\"): " + text.IndexOf("WORLD", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine();

            Console.WriteLine(text + " StartsWith(\"HELLO\"): " + text.StartsWith("HELLO", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine();
        }
    }
}
