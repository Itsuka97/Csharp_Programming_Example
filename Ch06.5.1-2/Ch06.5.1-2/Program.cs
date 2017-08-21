/* System.IO.BinaryWriter */
/* FileStream을 이용해 파일을 읽고 쓸 때 사람이 읽을 수 있게 하려면 StreamWriter를 사용하고,
 * 가독성을 무시하고 효율적으로 데이터를 기록하려면 BinaryWriter를 사용하면 된다 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ch06._5._1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream("test.log", FileMode.Create))
            {
                BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);
                bw.Write("Hello World" + Environment.NewLine);
                bw.Write("KangSangYeon" + Environment.NewLine);
                bw.Write(32000);

                // 현재 작성기에 대한 모든 버퍼를 지우면 버퍼링된 모든 데이터를 내부 장치에 씁니다.
                bw.Flush();
            }
        }
    }
}
