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
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string specialChars = "1234567890!@#$%^&*()_+-=[]{}|;':\",./<>?";

            Console.WriteLine("Хотите ли вы использовать цифры и спец.знаки");
            Console.Write("Введите ДА или НЕТ: ");
            string answer = Console.ReadLine();

            if (answer == "ДА")
            {
                for (int i = 0; i < length; i++)
                {
                    password.Append(chars[rnd.Next(chars.Length)] + specialChars[rnd.Next(specialChars.Length)]);
                }
                return password.ToString();
            }
            else 
            {
                for (int i = 0; i < length; i++)
                {
                    password.Append(chars[rnd.Next(chars.Length)]);
                }
                return password.ToString();
            }

        }
    }
}
