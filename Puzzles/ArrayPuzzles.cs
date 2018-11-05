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
            int SpaceCount=0, Index=0, i=0;
            for(i=0; i < TrueLength; i++)
            {
                if(Data[i]==' ')
                {
                    SpaceCount++;
                }
            }
            Index = TrueLength + SpaceCount * 2;

            for(i = TrueLength - 1; i >=0 ; i--)
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
    }
}
