/* 가변 매개변수 params 예약어 */
/* params 매개변수를 정의할 때는 입력받을 인자의 타입에 해당하는 배열을 선언한 다음 params 예약어를 붙이면 된다. 
 입력 타입을 지정할 수 없다면 모든 타입의 부모인 object를 사용할 수 있다. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch05._1._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAll(1, 2, 3, 4, "Hi~", "KangSangYeon");
        }

        private static void PrintAll(params object[] values)
        {
            foreach (object value in values)
                Console.WriteLine(value);
        }
    }
}
