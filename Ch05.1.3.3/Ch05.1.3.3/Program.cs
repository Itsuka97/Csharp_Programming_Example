/* Win32 ApPI 호출 extern 예약어 */
/* C/C++ 언어와의 호환성을 위해 제공되는 예약어 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Ch05._1._3._3
{
    class Program
    {

        [DllImport("user32.dll")]
        static extern int MessageBeep(uint uType);

        static void Main(string[] args)
        {
            MessageBeep(0);
        }
    }
}
