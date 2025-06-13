namespace Task3
{/* Задание 3
   Пользователь вводит строку с клавиатуры. Необходимо зашифровать данную строку используя шифр Цезаря.
 Из Википедии:
 ДОМАШНЕЕ ЗАДАНИЕ
 1
 Шифр Цезаря — это вид шифра подстановки, в котором каждый символ в открытом тексте заменяется
 символом, находящимся на некотором постоянном числе
 позиций левее или правее него в алфавите. Например,
 в шифре со сдвигом вправо на 3, A была бы заменена на
 D, B станет E, и так далее.
 Подробнее тут: https://en.wikipedia.org/wiki/Caesar_
 cipher.
 Кроме механизма шифровки, реализуйте механизм
 расшифрования.
  */
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите строку на английском: ");
            string userString = Input.UserInput.GetStringFromUser();
            Caesar caesar = new Caesar(userString, 5);
            caesar.CaesarEncript();
            string encripted = caesar.Source;
            caesar.CaesaDecrypt();
            string decripted = caesar.Source;

            Console.WriteLine(
                $"Ваша строка: {userString}\n" +
                $"Зашифрованная: {encripted}\n" +
                $"Расшифрованная обратно: {decripted}"
            );
        }
    }
}
