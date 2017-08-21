/* System.Collections.SortedList */
/* Hashtable에서는 키가 해시되어 데이터를 가리키는
 * 인덱스 요소로 사용됬던 반면
 * SortedList의 키는 그 자체가 정렬되어 값의 순서에 영향을 준다 
 
  Hashtable과 마찬가지로 키 값이 중복되는 경우 예외가 발생한다. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Ch06._4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();

            sl.Add(32, "Cooper");
            sl.Add(56, "Anderson");
            sl.Add(17, "Sammy");
            sl.Add(27, "Paul");

            foreach (int key in sl.GetKeyList())
                Console.WriteLine("{0} {1}", key, sl[key]);
        }
    }
}
