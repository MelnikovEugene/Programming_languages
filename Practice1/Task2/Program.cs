using System;

class Program
{
    static void Main()
    {
        // Вводим целое число N
        Console.Write("Введите целое число N: ");

        // Пытаемся преобразовать введенную строку в целое число
        if (int.TryParse(Console.ReadLine(), out int N))
        {
            // Вызываем функцию для вывода чисел в заданном диапазоне
            PrintNumbersInRange(-N, N);
        }
        else
        {
            // Если введено нецелое число, выводим сообщение об ошибке
            Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
        }
    }

    // Функция для вывода чисел в заданном диапазоне
    static void PrintNumbersInRange(int start, int end)
    {
        // Используем цикл для перебора чисел от start до end
        for (int i = start; i <= end; i++)
        {
            // Выводим текущее число
            Console.Write(i);

            // Добавляем запятую и пробел, если число не последнее в диапазоне
            if (i < end)
            {
                Console.Write(", ");
            }
        }

        // Переходим на новую строку после вывода всех чисел
        Console.WriteLine();
    }
}