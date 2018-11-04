using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles
{
    public static class StringPuzzles
    {
        public static bool IsStringContainingAllUniqueCharacters(string Data)
        {
            if (Data.Length < 2)
            {
                return true;
            }
            else
            {
                HashSet<char> charInData = new HashSet<char>();
                for (int i = 0; i < Data.Length; i++)
                {
                    if (charInData.Contains(Data[i]))
                    {
                        return false;
                    }
                    else
                    {
                        charInData.Add(Data[i]);
                    }
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
