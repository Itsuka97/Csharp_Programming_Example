/* System.IO.File */
/* 자주 사용되는 파일 조작 기능을 담은 정적 클래스.
 * 따라서 File 타입에서 제공되는 모든 메소드는 정적 메소드이다. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ch06._5._2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 경로가 지정되지 않으면 Environment.CurrentDirectory가 기본 경로로 사용됨.
            // 대상 폴더에 파일이 없다면
            File.Copy("test.log", "test.dat");

            // 대상 폴더에 파일이 있고, 덮어쓸 의도라면
            File.Copy("test.log", "test.dat", true);


            // 폴더가 동일하다면 파일명 변경
            File.Move("test.log", "test.dat");

            // 폴더가 다르다면 파일 이동
            File.Move("test.log", "C:\\temp\\test.dat");
        }
    }
}
