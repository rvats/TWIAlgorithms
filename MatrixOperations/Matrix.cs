using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperations
{
    public static class Matrix
    {
        public static int[][] TwoDimensionalArray;
        public static int[,] ArrayOfArray;

        public static bool FindKInTwoDimensionalArray(int K)
        {
            int numRows = TwoDimensionalArray.Length - 1;
            int midRow = numRows / 2;
            int numColumns = TwoDimensionalArray[0].Length - 1;
            int midColumn = numColumns / 2;
            while (midRow >= 0 && midRow <= numRows && midColumn >= 0 && midColumn <= numColumns)
            {
                if (
                    ((TwoDimensionalArray[midRow][0] <= K) && (TwoDimensionalArray[midRow][numColumns] >= K))
                    || (midRow == 0)
                    || (midRow == numRows)
                )
                {
                    while (midColumn >= 0 && midColumn <= numColumns)
                    {
                        if (TwoDimensionalArray[midRow][midColumn] == K)
                        {
                            return true;
                        }
                        else
                        {
                            if (TwoDimensionalArray[midRow][midColumn] > K)
                            {
                                if (midColumn == 0)
                                {
                                    return false;
                                }
                                midColumn = (0 + midColumn) / 2;
                            }
                            if (TwoDimensionalArray[midRow][midColumn] < K)
                            {
                                if (midColumn == numColumns - 1)
                                {
                                    midColumn = numColumns;
                                }
                                else if (midColumn == numColumns)
                                {
                                    midColumn++;
                                }
                                else
                                {
                                    midColumn = (midColumn + numColumns) / 2;
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (TwoDimensionalArray[midRow][0] > K)
                    {
                        midRow = (0 + midRow) / 2;
                    }
                    if (TwoDimensionalArray[midRow][numColumns] < K)
                    {
                        if (midRow == numRows - 1)
                        {
                            midRow = numRows;
                        }
                        else if (midRow == numRows)
                        {
                            midRow++;
                        }
                        else
                        {
                            midRow = (midRow + numRows) / 2;
                        }
                    }
                }
            }
            return false;
        }


        /// <summary>
        ///  function to check is subgrid is Magic Square 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <param name="f"></param>
        /// <param name="g"></param>
        /// <param name="h"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool MagicSquare(int a, int b, int c, int d, int e,
                        int f, int g, int h, int i)
        {
            int[] s1 = { a, b, c, d, e, f, g, h, i };
            int[] s2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Array.Sort(s1);

            // Elements of grid must contain all numbers from 1 to 
            // 9, sum of all rows, columns and diagonals must be 
            // same, i.e., 15. 
            if (
                Enumerable.SequenceEqual(s1, s2) && 
                (a + b + c) == 15 && (d + e + f) == 15 &&
                (g + h + i) == 15 && (a + d + g) == 15 &&
                (b + e + h) == 15 && (c + f + i) == 15 &&
                (a + e + i) == 15 && (c + e + g) == 15)
            {
                return true;
            }
            return false;
        }

        // Function to cound total Magic square subgrids 
        public static int CountMagicSquare()
        {
            int ans = 0;

            for (int i = 0; i < TwoDimensionalArray.Length - 2; i++)
                for (int j = 0; j < TwoDimensionalArray[0].Length - 2; j++)
                {

                    // if condition true skip check 
                    if (TwoDimensionalArray[i + 1][j + 1] != 5)
                        continue;

                    // check for magic square subgrid 
                    if (MagicSquare(TwoDimensionalArray[i][j], TwoDimensionalArray[i][j + 1],
                        TwoDimensionalArray[i][j + 2], TwoDimensionalArray[i + 1][j],
                        TwoDimensionalArray[i + 1][j + 1], TwoDimensionalArray[i + 1][j + 2],
                        TwoDimensionalArray[i + 2][j], TwoDimensionalArray[i + 2][j + 1],
                        TwoDimensionalArray[i + 2][j + 2]))
                    {
                        ans += 1;
                    }
                        
                }

            // return total magic sqaure 
            return ans;
        }
    }
}
