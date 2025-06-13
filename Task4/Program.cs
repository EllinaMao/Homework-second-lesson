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
            int min_r = 5, max_r = 15;
            int[,] matrixA = new int[row, col];
            int[,] matrixB = new int[col, row];

            int[,] A = {
            { 1, 2 },
            { 3, 4 },
            { 5, 6 }
        };

            // Матрица B (2x3)
            int[,] B = {
            { 7, 8, 9 },
            { 10, 11, 12 }
        };  
            try
            {

                Hw.MatrixArray.RandomMatrix(matrixA, min_r, max_r);
                Hw.MatrixArray.RandomMatrix(matrixB, min_r, max_r);

                Hw.MatrixArray.Output(matrixA);
                Hw.MatrixArray.Output(matrixB);

                int[,] matrixC = Hw.ArifmeticOperations.SummOfMatrix(matrixA, matrixB);
                Console.WriteLine("Сумма матриц: ");
                Hw.MatrixArray.Output(matrixC);
                int[,] matrixD = Hw.ArifmeticOperations.MultiplyByNumber(matrixA, 3);
                Console.WriteLine("Умножение матрицы на число: ");
                Hw.MatrixArray.Output(matrixD);
                int[,] matrixE = Hw.ArifmeticOperations.MultiplyMatrix(A, B);
                Console.WriteLine("Умножение матриц: ");
                Hw.MatrixArray.Output(matrixE);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }
    }
}
