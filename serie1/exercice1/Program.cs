using System;

namespace exercice1 {
    class Program {

        public struct Point3D {
            private double X, Y, Z;

            public Point3D(double x, double y, double z) {
                X = x;
                Y = y;
                Z = z;
            }

            public double DistanceToOrigin() {
                return Math.Sqrt(X * X + Y * Y + Z * Z);
            }

            override public string ToString() {
                return $"({X};{Y};{Z})";
            }
        }

        public static void SwapPoint(ref Point3D p1, ref Point3D p2) {
            var temp = p1;
            p1 = p2;
            p2 = temp;
        }

        static void Main(string[] args) {
            Point3D p1 = new Point3D(3, 3, 3);
            Point3D p2 = new Point3D(4, 4, 4);
            Console.WriteLine($"p1 : {p1}, p2 : {p2}");
            Console.WriteLine(p1.DistanceToOrigin());

            SwapPoint(ref p1,ref p2);
            Console.WriteLine($"p1 : {p1}, p2 : {p2}");
        }
    }
}
