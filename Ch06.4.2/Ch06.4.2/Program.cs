/* 검색 가능한 컬렉션 System.Collections.Hashtable */
/* 이 컬렉션은 값(value) 뿐만 아니라 해시에 사용되는 키(key)가 추가되어
 * 빠른 검색 속도를 자랑한다. 
 * 따라서 검색 속도의 중요도에 따라 ArrayList 또는 Hashtable을 선택할지 결정한다 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Ch06._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            // 4개의 요소를 컬렉션에 추가
            ht.Add("key1", "add");
            ht.Add("key2", "remove");
            ht.Add("key3", "update");
            ht.Add("key4", "search");

            // "key4" 키 값에 해당하는 값을 출력
            Console.WriteLine(ht["key4"]);

            // "key3" 키 값에 해당하는 요소를 컬렉션에서 삭제
            ht.Remove("key3");

            // "key2" 키 값에 해당하는 값을 "delete"로 변경
            ht["key2"] = "delete";


            Console.WriteLine();
            // 컬렉션의 모든 키 값을 열람하고, 그 키에 대응되는 값을 출력
            foreach (object key in ht.Keys)
                Console.WriteLine("{0} ==> {1}", key, ht[key]);
        }
    }
}
