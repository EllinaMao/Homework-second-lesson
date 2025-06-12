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
    internal class MatrixArray
    {
        static public void RandomMatrix(int[][] matrix)
        {
            Random rnd = new Random();

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = rnd.Next(-100, 100);
                }
            }
        }

        public static void Output(int[][] matrix)
        {

            Console.WriteLine("Matrix array");

            foreach (int[] row in matrix) 
            {
                foreach (int value in row)
                {
                    Console.Write($"{value,4} ");
                }
                Console.WriteLine();
            }
        }
    }
}

