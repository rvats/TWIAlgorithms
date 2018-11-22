using Models;
using Puzzles;
using System;
using System.Collections.Generic;

namespace MainDemo
{
    public static class PuzzleDemo
    {
        public static void PrintKFrequentElements()
        {
            Console.Write("Enter Length of Array Data: ");
            int length = int.Parse(Console.ReadLine());
            var ArrayData = new int[length];
            Console.WriteLine("Enter " + length + " Elements for Array Data: ");
            for (int i = 0; i < length; i++)
            {
                ArrayData[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter Value of K Frequent Elements to be find in Array Data: ");
            int K = int.Parse(Console.ReadLine());
            var Result = ArrayPuzzles.FindKFrequentElements(ArrayData, K);
            foreach(var element in Result)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

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
