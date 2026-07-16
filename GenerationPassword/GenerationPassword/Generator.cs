using System;
using System.Collections.Generic;
using System.Text;

namespace GenerationPassword
{
    class Password
    {
        public string GeneratePass(int length)
        {
            Random rnd = new Random();
            StringBuilder password = new StringBuilder();
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string specialChars = "!@#$%^&*()_+-=[]{}|;,./<>?";

            Console.WriteLine("Хотите ли вы использовать цифры и спец.знаки");
            Console.Write("Введите ДА или НЕТ: ");
            string answer = Console.ReadLine();

            if (answer == "ДА")
            {
                chars += specialChars;
                for (int i = 0; i < length; i++)
                {
                    password.Append(chars[rnd.Next(chars.Length)]);
                }
                return password.ToString();
            }
            else if (answer == "НЕТ")
            {
                for (int i = 0; i < length; i++)
                {
                    password.Append(chars[rnd.Next(chars.Length)]);
                }
                return password.ToString();
            }
            return "Неверный ввод. Пожалуйста, введите ДА или НЕТ.";
        }
    }
}
