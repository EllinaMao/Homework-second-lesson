using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw
{/*
  Найти в
 данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, общее
 произведение всех элементов, сумму четных элементов
 массива А, сумму нечетных столбцов массива В.
  */
    internal class ArifmeticOperations
    {
        static public int FindSimilarMax(int[] a, int[][] b)
        {
            int maxA = a.Max();
            int maxB = b.SelectMany(row => row).Max();
            int overallMax = Math.Max(maxA, maxB);
            return overallMax;
        }

        static public int FindSimilarMin(int[] a, int[][] b)
        {
            int minA = a.Min();
            int minB = b.SelectMany(row => row).Min();
            int overallMin = Math.Min(minA, minB);
            return overallMin;
        }

        static public int FindTotalSum(int[] a, int[][] b)
        {
            int sumA = a.Sum();
            int sumB = b.SelectMany(row => row).Sum();
            return sumA + sumB;
        }


        static public int FindTotalProduct(int[] a, int[][] b)
        {
            int productA = a.Aggregate(1, (acc, val) => acc * val);
            int productB = b.SelectMany(row => row).Aggregate(1, (acc, val) => acc * val);
            return productA * productB;
        }

        static public int SumEvenElementsA(int[] a)
        {
            return a.Where(x => x % 2 == 0).Sum();
        }

        static public int SumOddColumnsB(int[][] b)
        {
            if (b.Length == 0) return 0;
            int cols = b.Max(row => row.Length);
            int sum = 0;
            for (int col = 0; col < cols; col++)
            {
                if (col % 2 == 1) // нечетные столбцы 
                {
                    for (int row = 0; row < b.Length; row++)
                    {
                        if (col < b[row].Length)
                            sum += b[row][col];
                    }
                }
            }
            return sum;
        }

    }
}
