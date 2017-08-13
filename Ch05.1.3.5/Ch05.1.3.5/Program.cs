/* 참조 형식의 멤버에 대한 포인터 fixed 예약어 */
/* C/C++ 언어와의 호환성을 위해 제공된다. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch05._1._3._5
{
    class Managed
    {
        public int Count;
        public string Name;
    }

    class Program
    {
        unsafe static void Main(string[] args)
        {
            Managed inst = new Managed();

            inst.Count = 5;
            inst.Name = "text";

            fixed(int* pValue = &inst.Count)
            {
                *pValue = 6;
            }

            fixed(char* pChar = inst.Name.ToCharArray())
            {
                for (int i = 0; i < inst.Name.Length; i++)
                {
                    Console.WriteLine(*(pChar + i));
                }
            }
        }
    }
}
