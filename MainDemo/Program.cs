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
            var resultData = PuzzleDemo.GetWordsFromPhoneDigits();
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
