using System;

namespace MatrixOperations
{
    class MatrixCalculator
    {
        public static void MultiplyMatrices(int[,] matrixA, int[,] matrixB, out int[,] productMatrix, out int sumOfProduct)
        {
            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
            int colsB = matrixB.GetLength(1);

            productMatrix = new int[rowsA, colsB];
            sumOfProduct = 0;

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        sum += matrixA[i, k] * matrixB[k, j];
                    }
                    productMatrix[i, j] = sum;
                    sumOfProduct += sum;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrixA = { { 1, 2 }, { 5, 4 } };
            int[,] matrixB = { { 6, 6 }, { 3, 8 } };
            int[,] productMatrix;
            int sumOfProduct;

            MatrixCalculator.MultiplyMatrices(matrixA, matrixB, out productMatrix, out sumOfProduct);

            Console.WriteLine("Product Matrix:");
            for (int i = 0; i < productMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < productMatrix.GetLength(1); j++)
                {
                    Console.Write(productMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Sum of Product Matrix: {sumOfProduct}");
        }
    }
}
