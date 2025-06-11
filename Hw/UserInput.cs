using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal static class UserInput
    {
        public static int GetIntFromUser()
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.Beep(); //^-^
                    return number;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    Console.WriteLine("Пожалуйста, введите корректное число:");
                }}}
        public static double GetDoubleFromUser()
        {
            while (true)
            {
                try
                {
                    double number = Convert.ToDouble(Console.ReadLine());
                    Console.Beep(); //^-^
                    return number;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    Console.WriteLine("Пожалуйста, введите корректное число:");
                }
            }
        }

        public static string GetStringFromUser()
        {
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Ввод не может быть пустым или состоять только из пробелов.");
            }
            return input.Trim(); 
        }

    }


}
