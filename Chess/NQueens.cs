using System;
using System.Collections.Generic;

namespace Chess
{
    public static class NQueens
    {
        public static int QueenCount;
        public static int NumberOfColumnsOnBoard;
        public static int NumberOfRowsOnBoard;
        private static List<Tuple<int, int>> QueenPositions = new List<Tuple<int, int>>();

        public static List<Tuple<int, int>> GetQueensSafelyOnBoard(int firstQueensColumn = 0)
        {
            if (PlaceQueens(firstQueensColumn))
            {
                return QueenPositions;
            }
            return QueenPositions;
        }

        private static bool PlaceQueens(int column)
        {
            if (column >= NumberOfRowsOnBoard) return true;
            int row = 0;
            while (row < NumberOfRowsOnBoard)
            {
                QueenPositions.Insert(QueenPositions.Count, new Tuple<int, int>(row, column));
                if (IsSafePosition(row, column) && PlaceQueens(column + 1))
                {
                    return true;
                }
                QueenPositions.RemoveAt(QueenPositions.Count - 1);
                row++;
            }
            return false;
        }
        private static bool IsSafePosition(int row, int column)
        {
            int currentQueenRow = 0, currentQueenColumn = 0;
            for (int i = 0; i < QueenPositions.Count - 1; i++)
            {
                currentQueenRow = QueenPositions[i].Item1;
                currentQueenColumn = QueenPositions[i].Item2;
                if(row== currentQueenRow)
                {
                    return false;
                }
                if (Math.Abs(row - currentQueenRow) == Math.Abs(column - currentQueenColumn))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
