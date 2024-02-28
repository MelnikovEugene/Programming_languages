//Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

using System;

class Program
{
    static void Main(string[] args)
    {
        while (true) // Запускаем бесконечный цикл
        {
            Console.WriteLine("Введите целое число или 'q' для выхода:"); // Просим пользователя ввести число или 'q'
            string input = Console.ReadLine(); // Читаем ввод пользователя

            if (input.ToLower() == "q") // Если пользователь ввел 'q', завершаем программу
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            int number;
            if (int.TryParse(input, out number)) // Пытаемся преобразовать ввод пользователя в целое число
            {
                if (IsEvenSum(input)) // Если сумма цифр числа чётная, завершаем программу
                {
                    Console.WriteLine($"Сумма цифр числа {input} чётная. Программа завершена.");
                    break;
                }
            }
            else // Если ввод пользователя не является числом
            {
                Console.WriteLine("Введено некорректное значение. Пожалуйста, введите целое число или 'q' для выхода.");
            }
        }
    }

    static bool IsEvenSum(string number)
    {
        int sum = 0;
        foreach (char digit in number) // Проходим по каждой цифре числа
        {
            if (char.IsDigit(digit)) // Проверяем, является ли символ цифрой
            {
                int digitValue = digit - '0'; // Преобразуем символ цифры в числовое значение
                sum += digitValue; // Считаем сумму цифр числа
            }
        }
        return sum % 2 == 0; // Возвращаем true, если сумма цифр числа чётная, иначе false
    }
}
