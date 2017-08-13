/* 연산 범위 확인 checked, unchecked */
/* 표현 가능한 숫자의 범위를 넘어서는 경우가 생길 때,
 * 즉, 오버플로나 언더플로가 발생했을 때 오류를 발생시키면서 프로그램실행을 중지하는 예약어이다. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            short c = 32767;
            int n = 32768;

            checked
            {
                c++;
            }

            Console.WriteLine(c);
        }
    }
}
