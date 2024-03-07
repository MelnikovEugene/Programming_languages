/* Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Начальные условия:

int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
}; 
Выводится:

9   10  11  12
5   6   7   8
1   2   3   4 */

using System;

class Program
{
    static void Main()
    {
        int[,] numbers = new int[,] {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(numbers);

        int[,] swappedArray = SwapFirstLastRows(numbers);

        Console.WriteLine("\nМассив после замены:");
        PrintArray(swappedArray);
    }

    static int[,] SwapFirstLastRows(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == 0)
            {
                newArray[rows - 1, j] = array[i, j];
            }
            else if (i == rows - 1)
            {
                newArray[0, j] = array[i, j];
            }
            else
            {
                newArray[i, j] = array[i, j];
            }
        }
    }

    return newArray;
}

    // static void SwapItems(int[,] array, int i)
    // {
    //     int rows = array.GetLength(0);
    //     int temp = array[0, i];
    //     array[0, i] = array[rows, i];
    //     array[rows, i] = temp;
    // }

    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void PrintResult(int[,] numbers)
    {
        PrintArray(numbers);
    }
}
