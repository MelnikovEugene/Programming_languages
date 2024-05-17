// Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив, состоящий из средних арифметических значений по строкам двумерного массива. 

using System;

class Program
{
    static void Main(string[] args)
    {
        // Задаем двумерный массив
        int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // Выводим исходный массив на экран
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Формируем новый одномерный массив из средних арифметических значений по строкам
        double[] averages = CalculateAverages(array);

        // Выводим новый массив средних значений на экран
        Console.WriteLine("\nСредние арифметические значения по строкам:");
        PrintArray(averages);
    }

    // Метод для вычисления средних арифметических значений по строкам двумерного массива
    static double[] CalculateAverages(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);
        double[] averages = new double[rows]; // Создаем новый массив для хранения средних значений

        for (int i = 0; i < rows; i++)
        {
            double sum = 0;
            for (int j = 0; j < cols; j++)
            {
                sum += arr[i, j]; // Суммируем элементы строки
            }
            averages[i] = sum / cols; // Вычисляем среднее значение и сохраняем его в новом массиве
        }

        return averages;
    }

    // Метод для вывода одномерного массива на экран
    static void PrintArray(double[] arr)
    {
        foreach (double num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    // Метод для вывода двумерного массива на экран
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

