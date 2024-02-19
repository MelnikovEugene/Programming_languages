//  Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.
using System;

class Program
{
    static void Main()
    {
        // Создаем массив из 10 целых чисел
        int[] array = { 2, 7, 14, 23, 30, 46, 51, 62, 75, 88 };

        // Находим количество четных чисел в массиве
        int count = CountEvenNumbers(array);

        // Выводим результат
        Console.WriteLine($"Количество четных чисел в массиве: {count}");
    }

    // Метод для подсчета количества четных чисел в массиве
    static int CountEvenNumbers(int[] array)
    {
        int count = 0;

        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }

        return count;
    }
}
