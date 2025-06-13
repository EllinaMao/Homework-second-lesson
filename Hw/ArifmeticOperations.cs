using System;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Hw
{
    /*
      Найти в
     данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, общее
     произведение всех элементов, сумму четных элементов
     массива А, сумму нечетных столбцов массива В.
    */
    static public class ArifmeticOperations
    {

        static internal (int row, int col) MinIndexInMatrix(int[,] matrix)
        {
            int min = int.MaxValue;
            int minRow = -1, minCol = -1;
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        minRow = i;
                        minCol = j;
                    }
                }
            }
            return (minRow, minCol);
        }

        static internal (int row, int col) MaxIndexInMatrix(int[,] matrix)
        {
            int max = int.MinValue;
            int maxRow = -1, maxCol = -1;
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }
            return (maxRow, maxCol);
        }

        static public int MaxInMatrix(int[,] matrix)
        {
            int max = int.MinValue;//начинаем с самого маленького значения
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);//1 - индекс столбцов

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    if (matrix[i, j] > max)
                        max = matrix[i, j];
            return max;
        }

        static public int MinInMatrix(int[,] matrix)
        {
            int min = int.MaxValue;//начинаем с самого большого значения
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    if (matrix[i, j] < min)
                        min = matrix[i, j];
            return min;
        }

        static internal int FindSimilarMax(int[] a, int[,] b)
        {
            int maxA = a.Max();
            int maxB = MaxInMatrix(b);
            return Math.Max(maxA, maxB);
        }

        static internal int FindSimilarMin(int[] a, int[,] b)
        {
            int minA = a.Min();
            int minB = MinInMatrix(b);
            return Math.Min(minA, minB);
        }

        static internal int FindTotalSum(int[] a, int[,] b)
        {
            int sumA = a.Sum();
            int sumB = 0;
            int rows = b.GetLength(0);
            int cols = b.GetLength(1);

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    sumB += b[i, j];

            return sumA + sumB;
        }

        static internal int FindTotalProduct(int[] a, int[,] b)
        {
            int productA = a.Aggregate(1, (acc, val) => acc * val);
            int productB = 1;
            int rows = b.GetLength(0);
            int cols = b.GetLength(1);

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    productB *= b[i, j];

            return productA * productB;
        }

        static internal int SumEvenElementsA(int[] a)
        {
            int sum = 0;

            for (int i = 0; i < a.Length; i++)
                if (a[i] % 2 == 0)
                    sum += a[i];

            return sum;
        }

        static internal int SumOddColumnsB(int[,] b)
        {
            int sum = 0;
            int rows = b.GetLength(0);
            int cols = b.GetLength(1);

            for (int j = 1; j < cols; j += 2)
                for (int i = 0; i < rows; i++)
                    sum += b[i, j];

            return sum;
        }

        static public int SumBetweenMinMax(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            //находим минимальный и максимальный индекс var для кортежкика
            var (minRow, minCol) = MinIndexInMatrix(matrix);
            var (maxRow, maxCol) = MaxIndexInMatrix(matrix);

            //линейный индекс
            int minIndex = minRow * cols + minCol;
            int maxIndex = maxRow * cols + maxCol;

            //на случай если минимальный или максимальный елемент будет не в том порядке
            int start = Math.Min(minIndex, maxIndex) + 1;
            int end = Math.Max(minIndex, maxIndex);

            int sum = 0, index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++, index++)
                {
                    if (index >= start && index < end)
                        sum += matrix[i, j];
                }
            }

            return sum;
        }

        public static int[,] MultiplyByNumber(int[,] matrix, int number)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = matrix[i, j] * number;

            return result;
        }

        static public int[,] SummOfMatrix(int[,] matrixA, int[,] matrixB)
        {
            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
            int rowsB = matrixB.GetLength(0);
            int colsB = matrixB.GetLength(1);

            if (rowsA != rowsB || colsA != colsB)
            {
                throw new ArgumentException("Matrix sizes must match for addition.");
            }

            int[,] result= new int[rowsA, colsA];
            for (int i = 0; i<rowsA; i++)
            {
                for(int j = 0; j < colsA; j++)
                {
                    result[i,j] = matrixA[i, j] + matrixB[i, j];
                }
            }
            return result;
        }

        public static int[,] MultiplyMatrix(int[,] matrixA, int[,] matrixB)
        {
            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
            int rowsB = matrixB.GetLength(0);
            int colsB = matrixB.GetLength(1);

            if (colsA != rowsB)
                throw new ArgumentException("Number of columns in first matrix must equal number of rows in second matrix.");
            
            int[,] result = new int[rowsA, colsB];

            for (int i = 0; i < rowsA; i++)
                for (int j = 0; j < colsB; j++)
                    for (int k = 0; k < colsA; k++)
                        result[i, j] += matrixA[i, k] * matrixB[k, j];

            return result;



        }
    }
}
