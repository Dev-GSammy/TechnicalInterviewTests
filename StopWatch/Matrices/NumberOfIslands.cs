/*
Given a 2D grid map of 1s (land) and 0s (water), count the number of islands.

An island is surrounded by water and is formed by connecting adjacent lands 
horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.

Input: 
{
  { 1, 1, 0, 0, 1 },
  { 1, 1, 0, 0, 0 },
  { 0, 0, 1, 0, 0 },
  { 0, 0, 0, 1, 1 } };


Output: 2
*/

namespace TechnicalInterviewTests.Matrices
{
    public class NumberOfIslands
    {

        static int NUMBER_OF_ROWS = 4;
        static int NUMBER_OF_COLS = 5;

        public bool includeInSearch(int[,] gridMap, int row, int col, bool[,] visited)
        {
            return (row >= 0) && (row < NUMBER_OF_ROWS) && (col >= 0) && (col < NUMBER_OF_COLS) && (gridMap[row, col] == 1 && !visited[row, col]);
        }

        public void depthFirstSearch(int[,] gridMap, int row, int col, bool[,] visited)
        {
            int[] rowNeighbors = { -1, -1, -1, 0, 0, 1, 1, 1 };

            int[] colNeighbors = { -1, 0, 1, -1, 1, -1, 0, 1 };

            visited[row, col] = true;

            for (int i = 0; i < 8; ++i)
            {
                if (includeInSearch(gridMap, row + rowNeighbors[i], col + colNeighbors[i], visited))
                {
                    depthFirstSearch(gridMap, row + rowNeighbors[i], col + colNeighbors[i], visited);
                }
            }
        }

        public int findNumberOfIslands(int[,] gridMap)
        {
            bool[,] visitedCells = new bool[NUMBER_OF_ROWS, NUMBER_OF_COLS];

            int numberOfIslands = 0;

            for (int row = 0; row < NUMBER_OF_ROWS; ++row)
            {
                for (int col = 0; col < NUMBER_OF_COLS; ++col)
                {
                    if (gridMap[row, col] == 1 && !visitedCells[row, col])
                    {
                        depthFirstSearch(gridMap, row, col, visitedCells);
                        ++numberOfIslands;
                    }
                }
            }

            return numberOfIslands;

        }
    }
}

/*
 * int[,] gridMap = { { 1, 1, 0, 0, 1 },
                       { 1, 1, 0, 0, 0 },
                       { 0, 0, 0, 0, 0 },
                       { 0, 0, 0, 1, 1 } };

    Console.Write(islandsObject.findNumberOfIslands(gridMap));
 */