

namespace TechnicalInterviewTests.Matrices
{
    public class SpiralMatrix
    {
        /*
Given a 2D matrix, return all elements of the matrix in spiral order.

Input:
{ { 1, 2, 3, 4 },
  { 5, 6, 7, 8 },
  { 9, 10, 11, 12 },
  { 13, 14, 15, 16 } }

Output: 1 2 3 4 8 12 16 15 14 13 9 5 6 7 11 10
*/

        int startingRowIndex = 0;
        int startingColIndex = 0;

        public void printSpiralMatrix(int endingRowIndex, int endingColIndex, int[,] array)
        {
            while (startingRowIndex < endingRowIndex && startingColIndex < endingColIndex)
            {
                for (int index = startingColIndex; index < endingColIndex; index++)
                {
                    Console.Write(array[startingRowIndex, index] + " ");
                }

                startingRowIndex++;

                for (int index = startingRowIndex; index < endingRowIndex; index++)
                {
                    Console.Write(array[index, endingColIndex - 1] + " ");
                }

                endingColIndex--;

                if (startingRowIndex < endingRowIndex)
                {
                    for (int index = endingColIndex - 1; index >= startingColIndex; index--)
                    {
                        Console.Write(array[endingRowIndex - 1, index] + " ");
                    }
                    endingRowIndex--;
                }

                if (startingColIndex < endingColIndex)
                {
                    for (int index = endingRowIndex - 1; index >= startingRowIndex; index--)
                    {
                        Console.Write(array[index, startingColIndex] + " ");
                    }

                    startingColIndex++;
                }

            }
        }
    }
}
//spiralMatrix.printSpiralMatrix(4, 4, array);
  