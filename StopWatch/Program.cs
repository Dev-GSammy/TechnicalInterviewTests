using System;
using TechnicalInterviewTests;
using TechnicalInterviewTests.Matrices;
using TechnicalInterviewTests.String_And_Array;

namespace NewClass
{
    public class Program()
    {
        
        static void Main(string[] args)
        {
            var TwoDeeMatrix = new _2DMatrices();
            int[,] Matrix = {{0, 0, 0, 0},
{0, 0, 0, 1},
{0, 0, 0, 0}};
            TwoDeeMatrix.printMatrix(Matrix);
            
        }
       
    }
    
}


