/* System.IO.Path */
/* Path타입은 파일 경로와 관련해서 유용한 정적 메소드를 제공한다 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ch06._5._4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine(@"C:\", "test", "myfile.dat");
            Console.WriteLine(filePath);

            string newDirName = "my<new";   // 폴더명에 '<' 문자는 허용되지 않는다
            int include = newDirName.IndexOfAny(Path.GetInvalidFileNameChars());
            if (include != -1)
                Console.WriteLine("폴더명에 적합하지 않은 문자가 있음");


            // 크기가 0인 임시 파일을 생성하고 그 경로를 반환한다.
            string createdTempFilePath = Path.GetTempPath();
            Console.WriteLine(createdTempFilePath);

            // 임시 파일을 생성하지 않고 중복될 확률이 낮은 임시 파일 경로를 구한다.
            string tempFilePath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Console.WriteLine(tempFilePath);
        }
    }
}
