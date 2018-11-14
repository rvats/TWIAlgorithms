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
    }
}
