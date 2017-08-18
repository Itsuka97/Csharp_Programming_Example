using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch06._2._1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello World";

            Console.WriteLine(text + " Contains(\"Hello\"): " + text.Contains("Hello"));
            Console.WriteLine(text + " Contains(\"Halo\"): " + text.Contains("Halo"));
            Console.WriteLine();

            Console.WriteLine(text + " EndsWith(\"World\"): " + text.EndsWith("World"));
            Console.WriteLine(text + " EndsWith(\"ello\"): " + text.EndsWith("ello"));
            Console.WriteLine();

            Console.WriteLine(text + " GetHashCode(): " + text.GetHashCode());
            Console.WriteLine("Hello GetHashCode(): " + "Hello".GetHashCode());
            Console.WriteLine();

            Console.WriteLine(text + " IndexOf(\"World\"): " + text.IndexOf("World"));
            Console.WriteLine(text + " IndexOf(\"Halo\"): " + text.IndexOf("Halo"));
            Console.WriteLine();

            Console.WriteLine(text + " Replace(\"World\", \"\"): " + text.Replace("World", ""));
            Console.WriteLine(text + " Replace('o', 't'): " + text.Replace('o', 't'));
            Console.WriteLine();

            Console.Write(text + " Split('o'): ");
            foreach (string t in text.Split('o'))
                Console.Write(t + ", ");
            Console.WriteLine();
            Console.Write(text + " Split(' '): ");
            foreach (string t in text.Split(' '))
                Console.Write(t + ", ");
            Console.WriteLine();

            Console.WriteLine(text + " StartsWith(\"Hello\"): " + text.StartsWith("Hello"));
            Console.WriteLine(text + " StartsWith(\"Hello\"): " + text.StartsWith("ello"));
            Console.WriteLine();

            Console.WriteLine(text + " Substring(1): " + text.Substring(1));
            Console.WriteLine(text + " Substring(2, 3): " + text.Substring(2, 3));
            Console.WriteLine();

            Console.WriteLine(text + " ToLower(): " + text.ToLower());
            Console.WriteLine(text + " ToUpper(): " + text.ToUpper());
            Console.WriteLine();

            Console.WriteLine("\" Hello World \" Trim(): " + " Hello World ".Trim());
            Console.WriteLine(text + " Trim('H'): " + text.Trim('H'));
            Console.WriteLine(text + " Trim('d'): " + text.Trim('d'));
            Console.WriteLine(text + " Trim('H', 'd'): " + text.Trim('H', 'd'));
            Console.WriteLine();

            Console.WriteLine(text + " Length: " + text.Length);
            Console.WriteLine("Hello Length: " + "Hello".Length);
            Console.WriteLine();

            Console.WriteLine("Hello != World: " + ("Hello" != "World"));
            Console.WriteLine("Hello == World: " + ("Hello" == "World"));
            Console.WriteLine("Hello == HELLO: " + ("Hello" == "HELLO"));
            Console.WriteLine();
        }
    }
}
