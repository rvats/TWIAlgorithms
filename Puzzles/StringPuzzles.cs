using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles
{
    public static class StringPuzzles
    {
        public static char? FirstRecurringCharacter(string Data)
        {
            if (Data == string.Empty)
            {
                return null;
            }
            else
            {
                HashSet<char> charInData = new HashSet<char>();
                for(int i = 0; i < Data.Length; i++)
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
    }
}
