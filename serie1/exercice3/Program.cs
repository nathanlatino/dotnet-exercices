using System;
using System.IO;

namespace exercice3 {
    class Program {
        static void Main(string[] args) {
            String[] lines = File.ReadAllLines("Mesures.txt");
            int count = 0;
            foreach (var line in lines) {
                Console.Write($"{line}, ");
                if(++count % 10 == 0) {
                    Console.WriteLine();
                }
            }
        }
    }
}
