using homework;
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
    internal class SmallArray
    {
        public static void InitializeFromUserInput(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Введите элемент {i + 1} из {a.Length}: ");
                a[i] = homework.UserInput.GetIntFromUser();
            }
        }

        public static void OutArray(int[] a)
        {
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
        }
    }
}   