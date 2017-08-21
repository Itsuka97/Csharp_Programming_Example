/* System.Collections.Stack */
/* 자료구조의 스택을 그대로 구현한 컬렉션. LIFO 
 
 Stack 타입 역시 object를 인자로 다루기 때문에 박싱 문제가 발생한다. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Ch06._4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();

            st.Push(1);
            st.Push(5);
            st.Push(3);

            int last = (int)st.Pop();

            st.Push(7);

            while (st.Count > 0)
                Console.WriteLine(st.Pop() + ", ");
            // 스택을 Pop과정 없이 비우고 싶다면 st.Clear() 메소드를 호출해도 된다.
        }
    }
}
