using MatrixOperations;
using System;

namespace MainDemo
{
    class Program
    {
        public Program()
        {
        }

        static void Main(string[] args)
        {
            Matrix.TwoDimensionalArray = new int[][]
            {
                new int[]{1,2,3,4,5,6 },
                new int[]{7,8,9,10,11,12 },
                new int[]{13,14,15,16,17,18 },
                new int[]{19,20,21,22,23,24 }
            };
            bool result = true;
            while (result)
            {
                Console.Write("Enter A Number: ");
                int K = int.Parse(Console.ReadLine());
                result = Matrix.FindKInTwoDimensionalArray(K);
                Console.WriteLine(result 
                    ? K + " Found in The Given Two Dimensional Matrix"
                    : K + " Not Found in The Given Two Dimensional Matrix");
            }
            Matrix.TwoDimensionalArray = new int[][]
            {
                new int[] { 4, 3, 8, 4 },
                new int[] { 9, 5, 1, 9 },
                new int[]{ 2, 7, 6, 2 }
            };
            Console.WriteLine(Matrix.CountMagicSquare());
            Console.WriteLine("Press Any Key To Exit");
            Console.ReadKey();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
