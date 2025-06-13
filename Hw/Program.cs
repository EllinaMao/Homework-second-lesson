namespace Hw
{
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
    internal class Program
    {
        static void Main(string[] args)
        {
            int min_r = 0, max_r = 100;
            int row = 3, col = 4, size = 5;
            
            int[] A = new int[size];
            
            SmallArray.InitializeFromUserInput(A);
            SmallArray.OutArray(A);




            int[,] B = new int[row, col];
            MatrixArray.RandomMatrix(B, min_r, max_r);
            MatrixArray.Output(B);

            int max = ArifmeticOperations.FindSimilarMax(A, B);
            Console.WriteLine($"Общий максимальный элемент: {max}");

            int min = ArifmeticOperations.FindSimilarMin(A, B);
            Console.WriteLine($"Общий минимальный элемент: {min}");
            
            int summ = ArifmeticOperations.FindTotalSum(A, B);
            Console.WriteLine($"Cумма всех елементов: {summ}");

            int prod = ArifmeticOperations.FindTotalProduct(A, B);
            Console.WriteLine($"Умножение всех елементов: {prod}");
         
            int summOfEven = ArifmeticOperations.SumEvenElementsA(A);
            Console.WriteLine($"Сумма всех четных елементов А: {summOfEven}");

            int summOfOddCollums = ArifmeticOperations.SumOddColumnsB(B);
            Console.WriteLine($"Сумма всех нечетных елементов B: {summOfOddCollums}");
        }
    }
}
