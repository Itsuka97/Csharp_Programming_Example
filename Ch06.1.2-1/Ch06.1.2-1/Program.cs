/* System.TimeSpan */
/* 시간 간격 타입 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch06._1._2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime endOfYear = new DateTime(DateTime.Now.Year, 12, 31);
            DateTime now = DateTime.Now;

            Console.WriteLine("오늘 날짜: " + now);

            TimeSpan gap = endOfYear - now;
            Console.WriteLine("올해의 남은 날짜: " + gap.TotalDays);
        }
    }
}
