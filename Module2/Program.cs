using Module2.Extensions;
using System.Security.Cryptography;

namespace Module2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Исключение и обработка.
            // Задача 1: Деление на ноль
            Console.WriteLine("Введите первое целое число:");
            int.TryParse(Console.ReadLine(), out int number1);
            bool loop = true;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Введите второе целое число:");
                int.TryParse(Console.ReadLine(), out int number2);

                try
                {
                    int result = number1 / number2;
                    Console.WriteLine("Результат деления:" + result);
                    loop = false;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Деление на ноль невозможно!");
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
                Console.WriteLine("Файл не найден!");
            }

            // Задача 3: Обработка ошибок при парсинге чисел
            try
            {
                Console.WriteLine();
                Console.WriteLine("Введите число:");
                int number = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            }

            // Расширение типов.
            // Задача 1: Расширение для строк
            Console.WriteLine();
            Console.WriteLine("Введите предложение из нескольких слов:");
            string sentence = Console.ReadLine();
            Console.WriteLine($"В вашем предложении {sentence.CountWordsInString()} слов");

            // Задача 2: Расширение для чисел
            Console.WriteLine("Введите целое число:");
            int numberEvenCheck = Int32.Parse(Console.ReadLine());
            if (numberEvenCheck.IsNumberEven())
            {
                Console.WriteLine($"Число \"{numberEvenCheck}\" четное");
            }
            else
            {
                Console.WriteLine($"Число \"{numberEvenCheck}\" не четное");
            }

            // Задача 3: Расширение для списков
            List<string> fruits = new List<string>() 
            {
                "apple", 
                "banana", 
                "kiwi", 
                "orange", 
                "banana", 
                "grape",
                "red dragon", 
                "orange", 
                "banana",
                "kiwi", 
                "tangerin", 
                "banana"
            }; 

            Console.WriteLine();
            List<string> clearFruitsList = fruits.RemoveDuplicates();
            foreach (string fruit in clearFruitsList)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
