namespace Task7
{
    internal class Program
    {
        /*
         
 Задание 7
 Создайте приложение, проверяющее текст на недопустимые слова. Если недопустимое слово найдено, оно
 должно быть заменено на набор символов *. По итогам
 работы приложения необходимо показать статистику
 действий.
 Например, если и у нас есть такой текст:
 To be, or not to be, that is the question,
 Whether 'tis nobler in the mind to suffer
 The slings and arrows of outrageous fortune,
 Or to take arms against a sea of troubles,
 And by opposing end them? To die: to sleep;
 No more; and by a sleep to say we end
 The heart-ache and the thousand natural shocks
 That flesh is heir to, 'tis a consummation
 Devoutly to be wish'd. To die, to sleep
 Недопустимое слово: die.
 Результат работы:
 To be, or not to be, that is the question,
 Whether 'tis nobler in the mind to suffer
 The slings and arrows of outrageous fortune,
 ДОМАШНЕЕ ЗАДАНИЕ
 3
 Or to take arms against a sea of troubles,
 And by opposing end them? To ***: to sleep;
 No more; and by a sleep to say we end
 The heart-ache and the thousand natural shocks
 That flesh is heir to, 'tis a consummation
 Devoutly to be wish'd. To ***, to sleep.
 Статистика: 2 замены слова die.
         */
        static void Main(string[] args)
        {
            string source = "To be, or not to be, that is the question,\r\n Whether 'tis nobler in the mind to suffer\r\n The slings and arrows of outrageous fortune,\r\n Or to take arms against a sea of troubles,\r\n And by opposing end them? To die: to sleep;\r\n No more; and by a sleep to say we end\r\n The heart-ache and the thousand natural shocks\r\n That flesh is heir to, 'tis a consummation\r\n Devoutly to be wish'd. To die, to sleep";
          
            string[] banned =
            {"die",
            "take",
            "heart"
            };

            string result = Task6.ParceString.m2(source, banned);

        }
    }
}
