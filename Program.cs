using System;
using System.Text;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Устанавливаем корректную кодировку для вывода русского текста
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            const double usdToEurRate = 0.85;

            Console.WriteLine("=== КОНВЕРТЕР ВАЛЮТ USD -> EUR ===");
            Console.WriteLine($"Текущий курс: 1 USD = {usdToEurRate} EUR");
            Console.WriteLine();

            Console.Write("Введите сумму в USD: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double usdAmount))
            {
                if (usdAmount >= 0)
                {
                    double eurAmount = usdAmount * usdToEurRate;
                    Console.WriteLine();
                    Console.WriteLine($"Результат конвертации:");
                    Console.WriteLine($"{usdAmount:F2} USD = {eurAmount:F2} EUR");
                }
                else
                {
                    Console.WriteLine("Ошибка: Сумма не может быть отрицательной!");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Введите корректное число!");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}