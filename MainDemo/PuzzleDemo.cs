using Puzzles;
using System;

namespace MainDemo
{
    public static class PuzzleDemo
    {
        public static void FirstRecurringCharacter()
        {
            string Data = Console.ReadLine();
            Console.WriteLine(StringPuzzles.FirstRecurringCharacter(Data));
            Console.ReadKey();
        }

        public static void FirstNonRecurringCharacter()
        {
            string Data = Console.ReadLine();
            Console.WriteLine(StringPuzzles.FirstNonRecurringCharacter(Data));
            Console.ReadKey();
        }
    }
}
