using System;
using System.Linq;

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

    //public class OgrePath
    //{

    //    static int[][] Maze =
    //    {
    //        new int[] {2,1,0,0,0,0,0,0,0,0},
    //        new int[] {0,0,1,0,0,0,0,0,0,0},
    //        new int[] {1,0,0,0,0,1,0,1,0,0},
    //        new int[] {0,0,0,0,0,0,0,0,0,0},
    //        new int[] {0,0,1,1,0,0,0,0,0,0},
    //        new int[] {0,0,1,0,0,0,0,1,0,1},
    //        new int[] {1,1,0,0,0,0,0,0,0,0},
    //        new int[] {0,0,0,0,0,0,0,0,0,0},
    //        new int[] {0,0,0,0,0,1,1,0,0,0},
    //        new int[] {0,0,0,0,0,1,0,0,0,3}
    //    };

    //    public static bool[][] Visited = new bool[Maze.Length][Maze[0].Length];

    //    static ArrayList<Point> neighbors = new ArrayList<Point>();

    //    public static void main(String[] args)
    //    {
    //        OgrePath OP = new OgrePath();
    //        for (int i = 0; i < Maze.Length; i++)
    //        {
    //            for (int j = 0; j < Maze[i].Length; j++)
    //            {
    //                visited[j][i] = false;
    //            }
    //        }
    //        visited[getOgre(maze).x][getOgre(maze).y] = true;
    //        Console.WriteLine("Ogre: " + getOgre(maze));
    //        dfs(maze, getOgre(maze));
    //    }

    //    public static bool dfs(int[][] maze, Point p)
    //    {
    //        neighbors = getNeighbors(maze, p);
    //        if (maze[p.x][p.y] == 3)
    //        {
    //            System.out.println("FOUND IT");
    //            return true;
    //        }
    //        if (neighbors.isEmpty())
    //        {
    //            return false;
    //        }
    //        for (int i = 0; i < neighbors.size(); i++)
    //        {
    //            System.out.println("Nieghbors: " + neighbors);
    //            System.out.println(i + "(" + p.x + "," + p.y + ")");
    //            visited[neighbors.get(i).x][neighbors.get(i).y] = true;
    //            dfs(maze, neighbors.get(i));
    //        }
    //        return false;
    //    }

    //    public static ArrayList<Point> getNeighbors(int[][] maze, Point p)
    //    {
    //        ArrayList<Point> neighbors = new ArrayList<Point>();
    //        Point left = new Point();
    //        Point right = new Point();
    //        Point down = new Point();
    //        Point up = new Point();
    //        down.x = p.x - 1;
    //        down.y = p.y;
    //        if (valid(maze, down)) neighbors.add(down);
    //        up.x = p.x + 1;
    //        up.y = p.y;
    //        if (valid(maze, up)) neighbors.add(up);
    //        left.x = p.x;
    //        left.y = p.y - 1;
    //        if (valid(maze, left)) neighbors.add(left);
    //        right.x = p.x;
    //        right.y = p.y + 1;
    //        if (valid(maze, right)) neighbors.add(right);
    //        return neighbors;
    //    }

    //    public static boolean valid(int[][] maze, Point p)
    //    {
    //        if (inMaze(maze, p) && canGo(maze, p) && visited[p.x][p.y] == false) return true;
    //        else return false;
    //    }

    //    public static boolean inMaze(int[][] maze, Point p)
    //    {
    //        if (p.x < (maze[0].length - 1) && p.x > -1 && p.y < (maze.length - 1) && p.y > -1)
    //        {
    //            return true;
    //        }
    //        else return false;
    //    }

    //    public static boolean canGo(int[][] maze, Point p)
    //    {
    //        if (maze[p.x][p.y] != 1 && maze[p.x][p.y] != 4) return true;
    //        else return false;
    //    }

    //    public static Point getOgre(int[][] maze)
    //    {
    //        Point ogre = new Point();
    //        for (int i = 0; i < maze.length; i++)
    //        {
    //            for (int j = 0; j < maze[i].length; j++)
    //            {
    //                if (maze[i][j] == 2)
    //                {
    //                    ogre.x = j;
    //                    ogre.y = i;
    //                }
    //            }
    //        }
    //        return ogre;
    //    }
    //}
}
