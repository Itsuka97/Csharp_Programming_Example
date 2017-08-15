/* System.DateTime */
/* 시간 관련 타입 
 1초 = 1000밀리초
 1틱 = 10000밀리초 분의 1 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch06._1._1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime before = DateTime.Now;
            Sum();
            DateTime after = DateTime.Now;

            long gap = after.Ticks - before.Ticks;
            Console.WriteLine("Total Ticks: " + gap);
            Console.WriteLine("Milliseconds: " + (gap / 10000));
            Console.WriteLine("Seconds: " + (gap / 10000 / 10000));
        }
        
        private static long Sum()
        {
            long sum = 0;

            for (int i = 0; i < 1000000; i++)
            {
                sum += i;
            }

            return sum;
        }
    }
}
