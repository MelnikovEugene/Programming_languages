// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] CreateMatrix(int rowCount, int columnCount)
{
    int[,] matrix = new int[rowCount, columnCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}
        // Задаем двумерный массив
        int[,] array = CreateMatrix(5, 5);

        // Выводим исходный массив на экран
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Находим сумму элементов на главной диагонали
        int diagonalSum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            diagonalSum += array[i, i]; // Добавляем элементы на главной диагонали к сумме
        }

        // Выводим сумму на экран
        Console.WriteLine($"\nСумма элементов на главной диагонали: {diagonalSum}");
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

