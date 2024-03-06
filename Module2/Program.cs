using System.Security.Cryptography;

namespace Module2
{
    internal class Program
    {
        static void Main()
        {
            // Исключение и обработка.
            // Задача 1: Деление на ноль
            Console.WriteLine("Введите первое целое число:");
            int.TryParse(Console.ReadLine(), out int number1);
            bool loop = false;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Введите второе целое число:");
                int.TryParse(Console.ReadLine(), out int number2);

                try
                {
                    double result = (double)number1 / number2;
                    Console.WriteLine("Результат деления:" + result);
                    loop = false;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Деление на ноль невозможно!");
                    loop = true;
                }
            }
            while (loop);

            // Задача 2: Обработка исключения
            try
            {
            File.Open("test.txt", FileMode.Open);
            }
            catch (FileNotFoundException ex)
            { 
                Console.WriteLine("Файл по указанному пути не найден!");
            }

            // Задача 3: Обработка ошибок при парсинге чисел
            try
            {
                Console.WriteLine("Введите число:");
                int number = Int32.Parse(Console.ReadLine());
            } 
            catch (FormatException ex)
            { 
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            }

            // Расширение типов.
            // Задача 1: Расширение для строк
            // Задача 2: Расширение для чисел
            // Задача 3: Расширение для списков
        }
    }
}
