using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles
{
    public static class ArrayPuzzles
    {
        public static string URLify(char[] Data, int TrueLength)
        {
            int Index = Data.Length;

            for(int i = TrueLength - 1; i >=0 ; i--)
            {
                if(Data[i]==' ')
                {
                    Data[Index - 1] = '0';
                    Data[Index - 2] = '2';
                    Data[Index - 3] = '%';
                    Index -= 3;
                }
                else
                {
                    Data[Index - 1] = Data[i];
                    Index--;
                }
            }
            return new string(Data);
        }

        public static int LongestSubsequenceInArray(int[] data)
        {
            if (data == null)
            {
                return 0;
            }
            int length = data.Length;
            int[] cache = new int[length];
            for(int i = 1; i < length; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if (data[i] > data[j])
                        cache[i] = Math.Max(cache[i], cache[j] + 1);
                }
            }
            return cache[length-1];
        }
    }
}
