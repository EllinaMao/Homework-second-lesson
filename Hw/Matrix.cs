using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
      Задание 1
 Объявить одномерный (5 элементов) массив с именем A и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B. Заполнить одномерный массив
 А числами, введенными с клавиатуры пользователем, а
 двумерный массив В случайными числами с помощью
 циклов. Вывести на экран значения массивов: массива
 А в одну строку, массива В — в виде матрицы. Найти в
 данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, общее
 произведение всех элементов, сумму четных элементов
 массива А, сумму нечетных столбцов массива В.
 */
namespace Hw
{
    public static class MatrixArray
    {
        static public void RandomMatrix(int[,] matrix, int min, int max)
        {
            Random rnd = new Random();

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rnd.Next(min, max);
                }
            }
        }

        public static void Output(int[,] matrix)
        {

            Console.WriteLine("Matrix array");

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("{0,4}", matrix[i,j] );
                }
                Console.WriteLine();
            }
            Console.WriteLine("...........................................");
        }
    }
}

