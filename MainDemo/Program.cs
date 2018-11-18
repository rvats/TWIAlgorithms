using Maths;
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
            int[] Number = new int[] { 7, 2, 9, 7, 0, 1, 7 };
            var resultData = PuzzleDemo.GetWordsFromPhoneDigits(Number);
            foreach(var data in resultData)
            {
                Console.Write(data+ " ");
            }
            Console.WriteLine();
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
