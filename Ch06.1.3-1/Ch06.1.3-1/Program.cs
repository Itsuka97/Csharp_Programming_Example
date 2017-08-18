/* System.Diagnostics.Stopwatch */
/* TimeSpan보다 더 정확한 시간차 계산을 위한 타입 
 실제로 StopWatch 타입은 코드의 특정 구간에 대한 성능을 측정할 때 자주 사용됨 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch06._1._3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch st = new System.Diagnostics.Stopwatch();

            st.Start();
            Sum();
            st.Stop();

            Console.WriteLine("Total Ticks: " + st.ElapsedTicks);
            Console.WriteLine("Milliseconds: " + (st.ElapsedTicks / 10000));
            Console.WriteLine("Seconds: " + (st.ElapsedTicks / 10000 / 10000));
        }

        static long Sum()
        {
            long sum = 0;

            for (int i = 0; i < 100000; i++)
            {
                sum += i;
            }

            return sum;
        }
    }
}
