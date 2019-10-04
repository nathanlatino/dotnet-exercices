using System;

namespace exercice5 {
    class Program {


        static void Main(string[] args) {
            string s1 = "Hello World";
            string s2 = "Hello World";
            string s3 = s1;

            Console.WriteLine("EQUALS");
            Console.WriteLine($"s1,s2 : {s1.Equals(s2)} | s1,s3 : {s1.Equals(s3)} | s2, s3 : {s2.Equals(s3)}\n");
            Console.WriteLine("COMPARETO");
            Console.WriteLine($"s1,s2 : {s1.CompareTo(s2)} | s1,s3 : {s1.CompareTo(s3)} | s2, s3 : {s2.CompareTo(s3)}\n");
            Console.WriteLine("SYSTEM.REF");
            Console.WriteLine($"s1,s2 : { s1 == s2} | s1,s3 : {s1 == s3} | s2, s3 : {s2 == s3}\n");

            Console.WriteLine("---------\n");
            s3 += '!';

            Console.WriteLine("EQUALS");
            Console.WriteLine($"s1,s2 : {s1.Equals(s2)} | s1,s3 : {s1.Equals(s3)} | s2, s3 : {s2.Equals(s3)}\n");
            Console.WriteLine("COMPARETO");
            Console.WriteLine($"s1,s2 : {s1.CompareTo(s2)} | s1,s3 : {s1.CompareTo(s3)} | s2, s3 : {s2.CompareTo(s3)}\n");
            Console.WriteLine("SYSTEM.REF");
            Console.WriteLine($"s1,s2 : { s1 == s2} | s1,s3 : {s1 == s3} | s2, s3 : {s2 == s3}\n");


            //string réagi comme une type value et donc pas de référence
        }
    }
}
