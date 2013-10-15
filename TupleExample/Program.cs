using System;

namespace TupleExample
{
    class Program
    {
        static void Main()
        {
            var tupleThing = new TupleThing();
            var result = tupleThing.Operations(10, 3);

            Console.WriteLine("Sum: {0}, Subtract:{1}, Multiply: {2}, Division:{3}", result.Item1, result.Item2, result.Item3, result.Item4);
            Console.ReadLine();
        }
    }

    public class TupleThing
    {
        public Tuple<int, int, int, double> Operations(int i,int j)
        {
            return Tuple.Create(Sum(i,j), Subtract(i, j), Multiply(i,j), Divide(i,j));
        }

        private static int Sum(int i, int j)
        {
            return i + j;
        }

        private static int Subtract(int i, int j)
        {
            return i - j;
        }

        private static int Multiply(int i, int j)
        {
            return i*j;
        }

        private static double Divide(int i, int j)
        {
            return Convert.ToDouble(i)/j;
        }
    }
}
