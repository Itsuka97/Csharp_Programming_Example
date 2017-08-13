/* 연산자 우선순위 */
/* ||연산자보다 &&연산자가 우선순위가 더 높기 때문에
 true || false && false => true || true => true 가 된다. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch05._1._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            if(true || false && false)
            {
                Console.WriteLine("evaluated.");
            }
        }
    }
}
