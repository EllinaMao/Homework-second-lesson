using System;
using System.Collections.Generic;
using System.Linq;
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
    internal class ParceString
    {
        public static string Task6(string source)
        {
            var sb = new StringBuilder(source.Length);
            bool newSentence = true;

            foreach (char c in source)
            {
                if (newSentence && char.IsLetter(c))
                {
                    sb.Append(char.ToUpper(c));
                    newSentence = false;
                }
                else
                {
                    sb.Append(c);
                }

                if (c == '.' || c == '!' || c == '?')
                    newSentence = true;
                else if (!char.IsWhiteSpace(c) && c != '.' && c != '!' && c != '?')
                    newSentence = false;
            }

            return sb.ToString();
        }
    }
}
