namespace Task5
{
    /*
 Задание 5
 Пользователь с клавиатуры вводит в строку арифметическое выражение. Приложение должно посчитать
 его результат. Необходимо поддерживать только две
 операции: + и –.

     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите в строку арифметическое выражение. Программа поддерживает операции с + и с -, если введете что то другое оно будет проигнорировано, а число сплюсованно или сминусованно");
            string UserArifmetic = Input.UserInput.GetStringFromUser();
            int result = ArifmeticWithString.GetArifmetic(UserArifmetic);
            Console.WriteLine(result);

        }
    }
}
