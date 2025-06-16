using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/*
 1.	Разделение текста на предложения
Необходимо определить границы предложений. Обычно предложения заканчиваются точкой (.), восклицательным (!) или вопросительным знаком (?). Можно использовать перебор символов или регулярные выражения для поиска этих знаков.
2.	Поиск первой буквы после разделителя
После каждого разделителя (и в начале текста) нужно найти первую букву, игнорируя пробелы и другие неалфавитные символы.
3.	Изменение регистра найденной буквы
Как только найдена первая буква предложения, её нужно преобразовать в верхний регистр.
4.	Сборка итогового текста
После обработки всех предложений необходимо собрать изменённый текст обратно в одну строку, сохраняя исходные знаки препинания и пробелы.
5.	Обработка крайних случаев
Следует учесть ситуации с несколькими пробелами, отсутствием пробела после точки, аббревиатурами и т.д.*/
namespace Task6
{
    public class ParceString
    {
        internal static string AddCapitalLetters(string source)
        {
            // \s - пробельный символ
            // * - ноль или более раз (Квантификатор в регулярных выражениях — это специальный символ или последовательность, которая указывает, сколько раз должен повторяться предыдущий элемент (символ, группа или класс символов). например \s* - ноль или более пробельных символов
            // ^ - начало строки
            // | - или
            // [.!?] - любой знак из списка
            // Конструкция в регулярных выражениях ( ... ) называется группой.
            //•	Группа — это часть шаблона, заключённая в круглые скобки.
            /*•	match.Groups — коллекция групп, найденных регулярным выражением.
            •	[1] — первая группа (группы нумеруются с 1, 0 — всё совпадение целиком).
            •	.Value — строковое значение этой группы.
            В контексте шаблона (^|[.!?]\s*)([a-zA-Zа-яА-Я]):
            •	Groups[1] — это либо начало строки, либо конец предложения с пробелами.

            \p{L} в регулярных выражениях означает "любой символ, являющийся буквой" (от английского "Letter").(мама почему я раньше это не нашла)
             */
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            var parce = @"(^| [.!?]\s*)([\p{L}])";
            var result = Regex.Replace(source, parce, lambda => lambda.Groups[1].Value + lambda.Groups[2].Value.ToUpper());



            return result;
        }


        public static string BanWords(string source, string[] bannedwords, char toswap)
        {
            //.Where =- возвращает тру фалс
            /*
             Escapes a minimal set of characters (\, *, +, ?, |, {, [, (,), ^, $, ., #, and white space) by replacing them with their escape codes. This instructs the regular expression engine to interpret these characters literally rather than as metacharacters.
            
            $@"..." — это интерполированная строка с поддержкой escape-последовательностей для регулярных выражений.
            \b — это граница слова в регулярных выражениях. Она гарантирует, что поиск будет совпадать только с целым словом, а не его частью. Например, die не совпадёт с diet или side.
            RegexOptions.IgnoreCase
            Игнорирует регистр символов при поиске совпадений.*/


            foreach (var ban in bannedwords)
            {
                var parce = $@"\b{Regex.Escape(ban)}\b";
                source = Regex.Replace(source, parce, lambda =>
                {
                    return new string(toswap, ban.Length);
                }, RegexOptions.IgnoreCase);
            }
            return source;
        }







    }
}




