using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task5
{
    internal class ArifmeticWithString
    {

        static public int GetArifmetic(string source)
        {
            // Удаляем все пробелы для удобства обработки
            source = source.Replace(" ", "");

            // Если выражение начинается с '-', добавляем 0 в начало (например, "-2+3" -> "0-2+3")
            if (source.StartsWith("-"))
                source = "0" + source;

            // Используем регулярное выражение для поиска всех чисел с их знаками
            //https://learn.microsoft.com/dotnet/api/system.text.regularexpressions.regex
            var matches = Regex.Matches(source, @"[+-]?\d+");

            int result = 0;
            foreach (Match match in matches)
            {
                result += int.Parse(match.Value);
            }

            return result;
        }
    }
  }
