using Puzzles;
using System;

namespace MainDemo
{
    class PuzzleDemo : IDemo
    {
        public PuzzleDemo()
        {
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

        public void FirstMultipleOccuringCharacter()
        {
            string Data = Console.ReadLine();
            Console.WriteLine(StringPuzzles.FirstRecurringCharacter(Data));
            Console.ReadKey();
        }
    }
}
