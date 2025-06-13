namespace Task4
{
/*
 Задание 4
 Создайте приложение, которое производит операции
 над матрицами:
 ■ Умножение матрицы на число;
 ■ Сложение матриц;
 ■ Произведение матриц.
*/
    internal static class Program
    {
        static void Main(string[] args)
        {
            int row = 3, col = 3;
            int min_r = 1, max_r = 5;
            int[,] matrixA = new int[row, col];
            int[,] matrixB = new int[col, row];

            int[,] matrixC = new int[3, 2];
            int[,] matrixD = new int[2, 3];

            try
            {

                Hw.MatrixArray.RandomMatrix(matrixA, min_r, max_r);
                Hw.MatrixArray.RandomMatrix(matrixB, min_r, max_r);
                Hw.MatrixArray.RandomMatrix(matrixC, min_r, max_r);
                Hw.MatrixArray.RandomMatrix(matrixD, min_r, max_r);

                Hw.MatrixArray.Output(matrixA);
                Hw.MatrixArray.Output(matrixB);

                int[,] matrixE = Hw.ArifmeticOperations.SummOfMatrix(matrixA, matrixB);
                Console.WriteLine("Сумма матриц: ");
                Hw.MatrixArray.Output(matrixE);
                int[,] matrixF = Hw.ArifmeticOperations.MultiplyByNumber(matrixA, 3);
                Console.WriteLine("Умножение матрицы на число 3: ");
                Hw.MatrixArray.Output(matrixF);


                Console.WriteLine("Умножение матриц: "+
                    "\nОригиналы: ");
                Hw.MatrixArray.Output(matrixC);
                Hw.MatrixArray.Output(matrixD);
                Console.WriteLine("Результат: ");
                int[,] matrixG = Hw.ArifmeticOperations.MultiplyMatrix(matrixC, matrixD);
                Hw.MatrixArray.Output(matrixG);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }
    }
}
