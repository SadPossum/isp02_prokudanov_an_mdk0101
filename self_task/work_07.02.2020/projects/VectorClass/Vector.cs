using System;

namespace VectorClass
{
    class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double VectorLength()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
        }

        public static double ScalarProduct(Vector vector, Vector vector1)
        {
            return vector1.X * vector.X + vector1.Y * vector.Y + vector1.Z * vector.Z;
        }

        public static Vector VectorProduct(Vector vector, Vector vector1)
        {
            Vector res = new Vector(0, 0, 0);
            res.X = vector.Y * vector1.Z - vector.Z * vector1.Y;
            res.Y = vector.Z * vector1.X - vector.X * vector1.Z;
            res.Z = vector.X * vector1.Y - vector.Y * vector1.X;
            return res;
        }

        public override string ToString()
        {
            return $"vec(x: {X}; y: {Y}; z: {Z})";
        }
    }
}
