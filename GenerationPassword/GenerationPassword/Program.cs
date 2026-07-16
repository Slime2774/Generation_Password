namespace GenerationPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Password pas = new Password();
            while (true)
            {

                Console.Write("Введите длину пароля: ");
                int lengthPassword = int.Parse(Console.ReadLine());

                Console.WriteLine(pas.GeneratePass(lengthPassword));

                Console.WriteLine("Нажмите любую кнопку для продолжения\n\n");
                Console.ReadKey();
            }
        }
    }
}
