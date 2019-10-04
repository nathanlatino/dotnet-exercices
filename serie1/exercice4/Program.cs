using System;
using System.Collections;

namespace exercice4 {
    class Program {

        static string PrintTab(int[] tab) {
            string text = "";
            foreach (var value in tab) {
                text += $" {value},";
            }
            return text;
        }

        static string PrintTab(ArrayList tab) {
            string text = "";
            foreach (int value in tab) {
                text += $" {value},";
            }
            return text;
        }

        public static (ArrayList, ArrayList)  PairImpair(int[] tab) {
            var tabPair = new ArrayList();
            var tabImpair = new ArrayList();
            foreach (var value in tab) {
                if(value%2 == 0) {
                    tabPair.Add(value);
                } else {
                    tabImpair.Add(value);
                }
            }

            return (tabPair, tabImpair);
        }
        static void Main(string[] args) {
            int[] values = new int[20];
            var rand = new Random();
            for(int i=0; i < values.Length; i++) {
                values[i] = rand.Next() % 100;
            }
            var tab = PairImpair(values);
            Console.WriteLine($"pair : {PrintTab(tab.Item1)}\nimpair : {PrintTab(tab.Item2)}");
        }
    }
}
