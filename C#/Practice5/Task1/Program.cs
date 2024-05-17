// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
using System;

class Program
{
    static void Main(string[] args)
    {
        // Задаем двумерный массив
        int[,] array = {
            {2, 3, 4, 3},
            {4, 3, 4, 1},
            {2, 9, 5, 4}
        };

        // Выводим исходный массив на экран
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Заменяем элементы с четными индексами на их квадраты
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i % 2 == 0 && j % 2 == 0) // Проверяем, что оба индекса чётные
                {
                    array[i, j] = array[i, j] * array[i, j]; // Заменяем элемент на его квадрат
                }
            }
        }

        // Выводим измененный массив на экран
        Console.WriteLine("\nМассив после замены:");
        PrintArray(array);
    }

    // Метод для вывода массива на экран
    static void PrintArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

