namespace Task2
{/*
   Задание 2
 Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100.
 Определить сумму элементов массива, расположенных
 между минимальным и максимальным элементами.
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            int minR = -100, maxR = 100;
            int row = 5, col = 5;
            int[,] matrix = new int[row, col];

            Hw.MatrixArray.RandomMatrix(matrix, minR, maxR);
            Hw.MatrixArray.Output(matrix);

            int sum = Hw.ArifmeticOperations.SumBetweenMinMax(matrix);
            int min = Hw.ArifmeticOperations.MinInMatrix(matrix);
            int max = Hw.ArifmeticOperations.MaxInMatrix(matrix);

            Console.WriteLine(
                $"Минимальный элемент: {min}\n" +
                $"Максимальный элемент: {max}\n" +
                $"Сумма чисел между минимальным и максимальным элементом: {sum}"
            );


        }
    }
}
