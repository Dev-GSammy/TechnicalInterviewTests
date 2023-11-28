/*
Given a 2D matrix, if an element is 1, set its entire row and column to 1. Do it in place.

Input:
{{0, 0, 0, 0}, 
{0, 0, 0, 1}, 
{0, 0, 0, 0}};

Output:
{{0, 0, 0, 1}, 
{1, 1, 1, 1}, 
{0, 0, 0, 1}};
*/



namespace TechnicalInterviewTests.Matrices
{
    class _2DMatrices
    {
        //Couldn't solve this. My solution brought some other results. 
        public void TwoDMatrices(int[,] Matrix)
        {
            //int[,] Matrix = new int[3,4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Matrix[i, j] == 1)
                    {
                        for (int k = 0; k < Matrix.Length; k++)
                        {
                            Matrix[k, j] = 1;
                            Matrix[i, k] = 1;
                        }
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(Matrix[i, j] + ", ");
                }
                Console.WriteLine();
            }

        }









        //Mamoth Tutor's solution
        public void changeMatrix(int[,] matrix)
        {
            bool rowWith1 = false;
            bool colWith1 = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == 0 && matrix[row, col] == 1)
                    {
                        rowWith1 = true;
                    }
                    if (col == 0 && matrix[row, col] == 1)
                    {
                        colWith1 = true;
                    }
                    if (matrix[row, col] == 1)
                    {
                        matrix[0, col] = 1;
                        matrix[row, 0] = 1;
                    }
                }
            }

            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    if (matrix[0, col] == 1 || matrix[row, 0] == 1)
                    {
                        matrix[row, col] = 1;
                    }
                }
            }

            if (rowWith1 == true)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[0, col] = 1;
                }
            }

            if (colWith1 == true)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, 0] = 1;
                }
            }
        }

        public void printMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.Write("\n");
            }
        }
        
    }
}
