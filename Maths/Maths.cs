using System.Text;

namespace Maths
{
    public static class Maths
    {
        public static int Fibonnaci(int position)
        {
            int previousResult = 0, result = 1;
            
            if (position < 2)
            {
                return position;
            }
            else
            {
                for(int i = 2; i <= position; i++)
                {
                    var temp = result;
                    result = result + previousResult;
                    previousResult = temp;
                }
                return result;
            }
        }
        public static string CalculateBinary(int n)
        {
            int Length = 16;
            int Bit = 1 << Length - 1;
            StringBuilder PrintBit = new StringBuilder();
            while (Bit>0)
            {
                var printBit = ((n & Bit) > 0) ? 1 : 0;
                PrintBit.Append(printBit);
                Bit >>= 1;
            }
            return PrintBit.ToString();
        }
    }
}
