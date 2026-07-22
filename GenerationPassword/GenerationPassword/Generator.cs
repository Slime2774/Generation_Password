using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
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

            Console.WriteLine("Хотите ли ы использовать цифры и спец.знаки");
            Console.Write("Введите ДА или НЕТ: ");
            string answer = Console.ReadLine();



            if (answer != null && answer.Equals("ДА", StringComparison.OrdinalIgnoreCase))
            {
                chars += specialChars;
            }

            for (int i = 0; i < length; i++)
            {
                password.Append(chars[rnd.Next(chars.Length)]);
            }

            return password.ToString();



        }

    }
}
