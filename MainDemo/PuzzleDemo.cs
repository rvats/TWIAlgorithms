using Puzzles;
using System;

namespace MainDemo
{
    public static class PuzzleDemo
    {
        public static void FirstRecurringCharacter(string Data)
        {
            Console.WriteLine("First Recurring Character in " + Data + ": " + StringPuzzles.FirstRecurringCharacter(Data));
        }

        public static void FirstNonRecurringCharacter(string Data)
        {
            Console.WriteLine("First Non Recurring Character in " + Data + ": " + StringPuzzles.FirstNonRecurringCharacter(Data));
        }
    }
}
