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
            string UserInput = Input.UserInput.GetStringFromUser();
            //string UserInput = " Например, если пользователь ввёл: «today is a good\r\n day for walking. i will try to walk near the sea».\r\n Результат работы приложения: «Today is a good day\r\n for walking. I will try to walk near the sea».";
            string result = ParceString.AddCapitalLetters(UserInput);
            Console.WriteLine(result);
        }
    }
}
