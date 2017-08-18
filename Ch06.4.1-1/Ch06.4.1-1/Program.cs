/* 정해지지 않은 크기의 배열을 다뤄야 할 필요가 있는데
 * 이 같은 기능을 편리하게 구현한 것을 컬렉션(Collection)이라 한다. 
 
  ArrayList는 object를 인자로 갖기 때문에 닷넷의 모든 타입을 담을 수 있다는 장점이 있지만
  반대로 이로 인해 박싱이 발생한다는 단점이 있다.
  따라서 System.ValueType을 상속받는 값 형식을 위한 컬렉션으로는 적당하지 않다.
  이를 해결하기 위해서는 닷넷 2.0부터 지원되는 제네릭(Generic)이 적용된
  List<T> 타입을 사용하는 것을 권장한다. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Ch06._4._1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();

            // 4개의 요소를 컬렉션에 추가
            ar.Add("Hello");
            ar.Add(6);
            ar.Add("World");
            ar.Add(true);

            // 숫자 6을 포함하고 있는지 판단
            Console.WriteLine("Contains(6): " + ar.Contains(6));

            // "World" 문자열을 컬렉션에서 삭제
            ar.Remove("World");

            // 2번째 요소의 값을 false로 변경
            ar[2] = false;

            Console.WriteLine();
            // 컬렉션의 요소를 모두 출력
            foreach (object obj in ar)
                Console.WriteLine(obj);
        }
    }
}
