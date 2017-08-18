/* 콜렉션 타입 */
/* 사용자 정의 타입을 Sort하는 방법은
 * IComparer 인터페이스를 구현하면 된다. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Ch06._4._1_3
{
    public class Person : IComparable
    {
        public int Age;
        public string Name;

        public Person(int Age, string Name)
        {
            this.Age = Age;
            this.Name = Name;
        }

        public int CompareTo(object obj)    // 나이순으로 정렬한다
        {
            Person target = (Person)obj;

            if (this.Age > target.Age) return 1;        // 나이가 많으면 뒤로 보낸다
            else if (this.Age == target.Age) return 0;  // 같으면 그대로
            else return -1;                             // 나이가 적으면 앞으로 보낸다
        }

        public override string ToString()
        {
            return string.Format("{0}({1})", this.Name, this.Age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();

            ar.Add(new Person(32, "Cooper"));
            ar.Add(new Person(56, "Anderson"));
            ar.Add(new Person(17, "Sammy"));
            ar.Add(new Person(27, "Paul"));

            ar.Sort();

            foreach (Person person in ar)
                Console.WriteLine(person);
        }
    }
}
