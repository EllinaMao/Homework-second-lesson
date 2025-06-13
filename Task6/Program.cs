namespace Task6
{
    /*
 Задание 6
 Пользователь с клавиатуры вводит некоторый текст.
 Приложение должно изменять регистр первой буквы
 каждого предложения на букву в верхнем регистре.

 Например, если пользователь ввёл: «today is a good
 day for walking. i will try to walk near the sea».
 Результат работы приложения: «Today is a good day
 for walking. I will try to walk near the sea».

     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите какой то текст");
            string Userinput = Input.UserInput.GetStringFromUser();
            string result = ParceString.Task6(Userinput);
            Console.WriteLine(result);
        }
    }
}
