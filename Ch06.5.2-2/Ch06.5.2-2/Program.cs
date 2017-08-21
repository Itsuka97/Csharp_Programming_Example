/* System.IO.FileInfo */
/* File 타입의 기능을 인스턴스 멤버로 일부 구현하고 있다는 차이점을 제외하고
 * 거의 모든 면에서 사용법이 같다. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ch06._5._2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo source = new FileInfo("test.log");
            FileInfo target = new FileInfo("C:\\temp\\test.dat");

            if (target.Exists)
                target.Delete();

            source.MoveTo(target.FullName);
        }
    }
}
