﻿using System.Collections.Generic;
using System.Linq;

namespace Puzzles
{
    public static class StringPuzzles
    {
        /// <summary>
        /// * Cases to Discuss are 
        /// *  1) What about Empty Strings?
        /// *  2) ASCII or UNICODE(Also Check if Lower Case and Upper Case Be Considered Same)
        /// *  3) Can I Use Data structures or not? O(n)
        /// *  4) Can I sort the Data? O(NLogN)
        /// *  5) Brute Force O(N^2)
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>
        public static bool IsStringContainingAllUniqueCharacters(string Data)
        {
            int checker = 0;
            if (Data.Length < 2)
            {
                return true;
            }
            else
            {
                for (int i = 0; i < Data.Length; i++)
                {
                    int tempVariable = Data[i] - 'a';
                    if ((checker & (1<<tempVariable)) > 0)
                    {
                        return false;
                    }
                    checker |= (1 << tempVariable);
                }
            }
            return true;
        }
        
        public static bool ArePermutations(string Data1, string Data2)
        {
            if(Data1.Length != Data2.Length)
            {
                return false;
            }
            int[] countCharacters = new int[256];
            for(int i = 0; i < Data1.Length; i++)
            {
                countCharacters[Data1[i]]++;
            }
            for (int i = 0; i < Data2.Length; i++)
            {
                countCharacters[Data2[i]]--;
                if (countCharacters[Data2[i]] < 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static char? FirstRecurringCharacter(string Data)
        {
            if (Data.Length < 2)
            {
                return null;
            }
            else
            {
                HashSet<char> charInData = new HashSet<char>();
                for (int i = 0; i < Data.Length; i++)
                {
                    if (charInData.Contains(Data[i]))
                    {
                        return Data[i];
                    }
                    else
                    {
                        charInData.Add(Data[i]);
                    }
                }
            }
            return null;
        }

        public static char? FirstNonRecurringCharacter(string Data)
        {
            Dictionary<char, int> charInData = new Dictionary<char, int>();
            if (Data.Length == 0)
            {
                return null;
            }
            else
            {
                for (int i = 0; i < Data.Length; i++)
                {
                    if (charInData.ContainsKey(Data[i]))
                    {
                        charInData[Data[i]]++;
                    }
                    else
                    {
                        charInData.Add(Data[i], 1);
                    }
                }
            }
            if (charInData.ContainsValue(1))
            {
                return charInData.First(x => x.Value == 1).Key;
            }
            return null;
        }
    }
}
