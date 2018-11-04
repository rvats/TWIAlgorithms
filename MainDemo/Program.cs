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
            Console.Write("Enter Your Data String: ");
            var Data = Console.ReadLine();
            PuzzleDemo.IsStringContainingAllUniqueCharacters(Data);
            PuzzleDemo.FirstRecurringCharacter(Data);
            PuzzleDemo.FirstNonRecurringCharacter(Data);
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
