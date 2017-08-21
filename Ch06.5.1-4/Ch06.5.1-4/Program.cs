using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ch06._5._1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("C:\\temp");

            Environment.CurrentDirectory = "C:\\temp";

            using (FileStream fs = new FileStream("test.log", FileMode.Create))
            {
                // 생략
            }
        }
    }
}
