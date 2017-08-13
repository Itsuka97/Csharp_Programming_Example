/* 전처리기 지시문 #if */
#define OUTPUT_LOG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch05._1._1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            if (string.IsNullOrEmpty(text) == false)
            {
                Console.WriteLine("사용자 입력: " + text);
            }
            #if OUTPUT_LOG
            else
            {
                Console.WriteLine("입력되지 않음");
            }
            #endif
        }
    }
}
