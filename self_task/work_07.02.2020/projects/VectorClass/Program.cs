using System;

namespace VectorClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector = new Vector(5, 3, 9);
            Vector vector1 = new Vector(7, 2, 6);

            Console.WriteLine(vector.ToString());
            Console.WriteLine(vector1.ToString());

            Console.WriteLine($"Длина ветора 1: {vector.VectorLength()}");
            Console.WriteLine($"Длина ветора 2: {vector1.VectorLength()}");

            Console.WriteLine($"Скалярное произведение векторов 1 и 2: {Vector.ScalarProduct(vector, vector1)}");

            Console.WriteLine($"Векторное произведение векторов 1 и 2: {Vector.VectorProduct(vector, vector1)}");
            Console.ReadKey();
        }
    }
}
