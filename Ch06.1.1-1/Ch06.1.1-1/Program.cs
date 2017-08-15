/* System.DateTime
 * 시간 관련 타입 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch06._1._1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime dayForChildren = new DateTime(now.Year, 5, 5);
            Console.WriteLine(dayForChildren);
        }
    }
}
