using Models;
using Puzzles;
using System;
using System.Collections.Generic;

namespace MainDemo
{
    public static class PuzzleDemo
    {
        public static void IsStringContainingAllUniqueCharacters(string Data)
        {
            var result = StringPuzzles.IsStringContainingAllUniqueCharacters(Data)
                ? Data + " contains characters which are all unique."
                : Data + " contains characters which are not unique.";
            Console.WriteLine(result);
        }

        public static void FirstRecurringCharacter(string Data)
        {
            Console.WriteLine("First Recurring Character in " + Data + ": " + StringPuzzles.FirstRecurringCharacter(Data));
        }

        public static void FirstNonRecurringCharacter(string Data)
        {
            Console.WriteLine("First Non Recurring Character in " + Data + ": " + StringPuzzles.FirstNonRecurringCharacter(Data));
        }

        public static void ArePermutations(string Data1, string Data2)
        {
            var result = StringPuzzles.ArePermutations(Data1, Data2)
                ? Data1 + " is a permutation of " + Data2
                : Data1 + " is not a permutation of " + Data2;
            Console.WriteLine(result);
        }

        public static void URLify(string Data)
        {
            int TrueLength = Data.TrimEnd().Length;
            var result = "URLify " + Data.TrimEnd() + " is " + ArrayPuzzles.URLify(Data.ToCharArray(), TrueLength);
            Console.WriteLine(result);
        }

        public static List<string> GetWordsFromPhoneDigits(int[] Number)
        {
            return MatrixPuzzles.GetWordsFromPhoneDigits(Number);
        }

        public static long CalculateOverLapArea(Rectangle2DPlane rectangle1, Rectangle2DPlane rectangle2)
        {
            return GeometryPuzzles.CalculateOverLapArea(rectangle1, rectangle2);
        }
    }
}
