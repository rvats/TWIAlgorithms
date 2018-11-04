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
            var Data1 = Console.ReadLine();
            PuzzleDemo.IsStringContainingAllUniqueCharacters(Data1);
            PuzzleDemo.FirstRecurringCharacter(Data1);
            PuzzleDemo.FirstNonRecurringCharacter(Data1);
            Console.Write("Enter Another Data String: ");
            var Data2 = Console.ReadLine();
            PuzzleDemo.ArePermutations(Data1, Data2);
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
