using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Caesar
    {
        readonly int Key;
        public string Source
        {
            get;
            set;
        }

        public Caesar(string input)
        {
            Key = 3;
            Source = input;

        }
        public Caesar(string input, int _key)
        {
            Source = input;
            Key = _key;
        }



        public void CaesarEncript()
        {
            if (string.IsNullOrEmpty(Source))
            {
                return;
            }
            var encript = new StringBuilder(Source.Length);

                foreach (char l in Source)
                {
                    if (char.IsLetter(l))
                    {
                        char base_ = char.IsUpper(l) ? 'A' : 'a';//проверка на большой маленький символ для расчета позиции
                        char encriptChar = (char)(((l - base_ + Key) % 26) + base_);

                        encript.Append(encriptChar);
                    }
                    else if (char.IsDigit(l))
                    {
                        int digit = l - '0'; // получаем числовое значение цифры
                        int encryptedDigit = (digit + Key) % 10; // сдвигаем и оборачиваем по модулю 10
                        char encryptedChar = (char)(encryptedDigit + '0'); // преобразуем обратно в символ
                        encript.Append(encryptedChar);
                    }
                    else
                    {
                        encript.Append(l);
                        //просто добавить
                    }
                }
            Source = encript.ToString();

        }

        public void CaesaDecrypt() {
            if (string.IsNullOrEmpty(Source))
            {
                return;
            }
            var decripted = new StringBuilder(Source.Length);//что бы не выделять каждый раз память
            foreach (char l in Source)
            {
                if (char.IsLetter(l))
                {
                    char base_ = char.IsUpper(l) ? 'A' : 'a';
                    char decrpt = (char)(((l - base_ - Key + 26) % 26) + base_);
                    decripted.Append(decrpt);
                }
                else if (char.IsDigit(l))
                {
                    int digit = l - '0';
                    int decriptedDigit = (digit - Key + 10) % 10;
                    char decriptedChar = (char)(decriptedDigit + '0');
                    decripted.Append(decriptedChar);
                }
                else
                {
                    decripted.Append(l);
                }
                
             }
          Source = decripted.ToString();
        }
    }
}
