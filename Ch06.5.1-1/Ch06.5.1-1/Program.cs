/* 파일을 다루기 위한 기본적인 타입 System.IO.FileStream */
/* MemoryStream은 메모리에 할당한 바이트 배열을 대상으로 읽기/쓰기 작업을 했지만
 * FileStream은 디스크의 파일을 대상으로 읽기/쓰기 작업을 한다 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ch06._5._1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            using(FileStream fs = new FileStream("test.log", FileMode.Create))
            {
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.WriteLine("Hello World");
                sw.WriteLine("KangSangYeon");
                sw.WriteLine(32000);

                // 현재 writer의 모든 버퍼를 지우면 버퍼링된 모든 데이터가 내부 스트림에 쓰여집니다.
                sw.Flush();
            }
        }
    }
}
