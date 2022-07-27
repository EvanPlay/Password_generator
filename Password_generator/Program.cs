using System;
namespace Password_generator
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Программа для генерации сложных числовых-буквенных паролей.");
            Console.WriteLine("Выбирите способ генерации пароля: ");
            Console.WriteLine("1 - Генерация длинного пароля. 2 - генерация пароля с пробелами");

            int a;

            a = Convert.ToInt32(Console.ReadLine());

            try
            {
                Generation password = new Generation();
                while (true)
                {
                    Generation.Password(a);
                    Console.WriteLine();
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
