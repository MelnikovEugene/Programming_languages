//Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,90].
using System;

class Program
{
    static void Main()
    {
        // Создаем массив из 10 целых чисел
        int[] numbers = new int[] { 5, 15, 25, 35, 45, 55, 65, 75, 85, 95 };

        // Находим количество элементов в отрезке [10, 90]
        int count = CountElementsInRange(numbers, 10, 90);

        // Выводим результат
        Console.WriteLine($"Количество элементов в отрезке [10, 90]: {count}");
    }

    // Метод для подсчета количества элементов в отрезке [min, max]
    static int CountElementsInRange(int[] numbers, int minRange, int maxRange)
    {
        int count = 0;

        foreach (int element in numbers)
        {
            if (element >= minRange && element <= maxRange)
            {
                count++;
            }
        }

        return count;
    }
}

