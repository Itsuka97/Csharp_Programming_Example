/* System.DateTime */
/* 시간 관련 타입 
 시간대 관련 예제*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch06._1._1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now + ": " + now.Kind);

            DateTime utcNow = DateTime.UtcNow;
            Console.WriteLine(utcNow + ": " + utcNow.Kind);

            DateTime worldcup2002 = new DateTime(2002, 5, 31);
            Console.WriteLine(worldcup2002 + ": " + worldcup2002.Kind);

            worldcup2002 = new DateTime(2002, 5, 31, 0, 0, 0, DateTimeKind.Local);
            Console.WriteLine(worldcup2002 + ": " + worldcup2002.Kind);
        }
    }
}
