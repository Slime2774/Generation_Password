using TextCopy;

namespace GenerationPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Password pas = new Password();
            while (true)
            {
                Console.Clear();
                Console.Write("Введите длину пароля: ");
                bool lengthPassword = int.TryParse(Console.ReadLine(), out int result);

                if (lengthPassword)
                {

                    string password = pas.GeneratePass(result);
                    Console.WriteLine($"Ваш пароль: <{password}> скопирован в буфер");
                    ClipboardService.SetText(password);
                    
                }
                else
                {
                    Console.WriteLine("Неверный ввод! Попробуйте ещё раз!!");
                }
                Console.WriteLine("Нажмите любую кнопку для продолжения\n\n");
                Console.ReadKey();
            }
        }
    }
}
