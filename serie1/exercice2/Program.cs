using System;

namespace exercice2 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Rentrez un nombre réel positif : ");
            String output = Console.ReadLine();
            double A = Convert.ToDouble(output);
            double X = A;
            int count = 0;
            DateTime time = DateTime.Now;
            while(X-Math.Sqrt(A) > A*Math.Pow(10,-9)) {
                X = (X + A / X) / 2;
                Console.WriteLine($"approximation de la racine carrée de {A} est {string.Format($"{X:N4}")}");
                count++;
            }

            Console.WriteLine($"nombre d'iteration : {count}");
            Console.WriteLine($"temps écoulé : {(DateTime.Now - time).TotalSeconds}s");
            Console.WriteLine($"erreur résiduelle : {X - Math.Sqrt(A)}");
        }
    }
}
