/* 인코딩 관련 타입 System.Text.Encoding */
/* 효율상의 이유로 UTF-8 방식을 자주 쓰는 추세임 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch06._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string textData = "Hello World";

            byte[] buf = Encoding.UTF8.GetBytes(textData);
            // 생략: buf 바이트 배열을 자바 프로그램에 전달

            //byte[] received = ...; // 생략: 자바 프로그램으로부터 전달받은 바이트 배열 데이터
            //string data = Encoding.UTF8.GetString(received);
        }
    }
}
