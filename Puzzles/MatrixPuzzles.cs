using System.Collections.Generic;

namespace Puzzles
{
    public static class MatrixPuzzles
    {
        private static readonly List<char[]> phoneDigitsList = new List<char[]> { "".ToCharArray(), "".ToCharArray(), "abc".ToCharArray(), "def".ToCharArray(), "ghi".ToCharArray(), "jkl".ToCharArray(), "mno".ToCharArray(), "pqrs".ToCharArray(), "tuv".ToCharArray(), "wxyz".ToCharArray() };
        private static List<string> FinalResult = new List<string>();

        private static void GetWordsFromPhoneDigitsUtil(int[] Number, int CurrentDigit, char[] Output, int Num)
        {
            // A recursive function to print all possible words that can be obtained 
            // by input number[] of size n.  The output words are one by one stored 
            // in output[]
            // Base case, if current output word is prepared 
            int i;
            if (CurrentDigit == Num)
            {
                FinalResult.Add(new string(Output));
                return;
            }

            // Try all 3 possible characters for current digir in number[] 
            // and recur for remaining digits 
            for (i = 0; i < phoneDigitsList[Number[CurrentDigit]].Length; i++)
            {
                Output[CurrentDigit] = phoneDigitsList[Number[CurrentDigit]][i];
                GetWordsFromPhoneDigitsUtil(Number, CurrentDigit + 1, Output, Num);
                if (Number[CurrentDigit] == 0 || Number[CurrentDigit] == 1)
                    return;
            }
            return;
        }
 
        public static List<string> GetWordsFromPhoneDigits(int[] Number, int Num)
        {
            char[] result = new char[Number.Length];
            GetWordsFromPhoneDigitsUtil(Number, 0, result, Num);
            return FinalResult;
        }
    }
}
