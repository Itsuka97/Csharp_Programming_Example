/* 컬렉션 타입 */
/* ArrayList의 Sort 메소드를 호출할 때 제약사항은
 * ArrayList 안에 있는 요소가 모두 같은 타입이어야 한다는 것이다. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Ch06._4._1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();

            ar.Add("Hello");
            ar.Add("World");
            ar.Add("My");
            ar.Add("Sample");

            ar.Sort();

            foreach (string txt in ar)
                Console.WriteLine(txt);
        }
    }
}
