/* System.IO.Directory */
/* Directory 타입은 정적 멤버로 구성된 정적 타입이다 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ch06._5._3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string txt in Directory.GetLogicalDrives())
                Console.WriteLine(txt);

            Console.WriteLine();

            string frameworkPath = @"C:\Windows\Microsoft.NET\Framework";
            foreach (string txt in Directory.GetFiles(frameworkPath))
                Console.WriteLine(txt);

            Console.WriteLine();

            foreach (string txt in Directory.GetDirectories(frameworkPath))
                Console.WriteLine(txt);

            Console.WriteLine();
            
            foreach (string txt in Directory.GetFiles(frameworkPath, "*.exe", SearchOption.AllDirectories))
                Console.WriteLine(txt);
        }
    }
}
