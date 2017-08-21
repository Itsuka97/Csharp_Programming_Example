using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ch06._5._1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 로깅 목적의 파일 열기
            using (FileStream fs = new FileStream("log.txt", FileMode.Append))
            {
                // 쓰기 작업
            }

            // 전용 데이터 입출력
            using (FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
            {
                // 읽기/쓰기 작업
            }

            // 임시 데이터 입출력
            using (FileStream fs = new FileStream("temp.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.None))
            {
                // 읽기/쓰기 작업
            }
        }
    }
}
