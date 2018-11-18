using Chess;
using System;

namespace MainDemo
{
    public static class GameDemo
    {
        public static void NQueensDemo()
        {
            NQueens.QueenCount = 8;
            NQueens.NumberOfRowsOnBoard = 8;
            NQueens.NumberOfColumnsOnBoard = 8;
            var QueenPositions = NQueens.GetQueensSafelyOnBoard();
            int i = 1;
            if (QueenPositions.Count > 0)
            {
                foreach (var tuple in QueenPositions)
                {
                    Console.WriteLine("Queen " + i + " is on Row " + (tuple.Item1 + 1).ToString() + " and Column " + (tuple.Item2 + 1).ToString());
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Its an unwinnable situation");
            }
        }

    }
}
