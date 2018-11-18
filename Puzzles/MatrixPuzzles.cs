using System.Collections.Generic;

namespace Puzzles
{
    public static class MatrixPuzzles
    {
        private static readonly List<char[]> phoneDigitsList = new List<char[]>
        {
            "".ToCharArray(), // Digit 0 On Phone
            "".ToCharArray(), // Digit 1 On Phone
            "abc".ToCharArray(), // Digit 2 On Phone
            "def".ToCharArray(), // Digit 3 On Phone
            "ghi".ToCharArray(), // Digit 4 On Phone
            "jkl".ToCharArray(), // Digit 5 On Phone
            "mno".ToCharArray(), // Digit 6 On Phone
            "pqrs".ToCharArray(), // Digit 7 On Phone
            "tuv".ToCharArray(), // Digit 8 On Phone
            "wxyz".ToCharArray() // Digit 9 On Phone
        };
        private static List<string> FinalResult = new List<string>();

        private static void GetWordsFromPhoneDigitsUtil(int[] Number, int CurrentDigit, char[] Output)
        {
            int arrayLength = Number.Length;
            // Base case, if current output word is prepared 
            int i;
            if (CurrentDigit == arrayLength)
            {
                FinalResult.Add(new string(Output));
                return;
            }

            // Try all 3 possible characters for current digir in number[] 
            // and recur for remaining digits 
            for (i = 0; i < phoneDigitsList[Number[CurrentDigit]].Length; i++)
            {
                Output[CurrentDigit] = phoneDigitsList[Number[CurrentDigit]][i];
                GetWordsFromPhoneDigitsUtil(Number, CurrentDigit + 1,Output);
                if (Number[CurrentDigit] == 0 || Number[CurrentDigit] == 1)
                    return;
            }
            return;
        }
 
        public static List<string> GetWordsFromPhoneDigits(int[] Number)
        {
            int arrayLength = Number.Length;
            char[] Output = new char[arrayLength];
            GetWordsFromPhoneDigitsUtil(Number,0,Output);
            return FinalResult;
        }
    }
}
