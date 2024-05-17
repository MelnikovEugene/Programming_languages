// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет: "Позиция по рядам выходит за пределы массива"
// или "Позиция по колонкам выходит за пределы массива"
// Позиции в массиве считать от единицы.
// В коде, начальные условия:

// int[,] numbers = new int[,] {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// };
// Пример:
// int x = 2;
// int y = 2;
// Выводится: 6

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] numbers = new int[,] {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
        };

        int x = 2;
        int y = 2;

        int result = GetValueAtPosition(numbers, x, y);

        if (result != int.MinValue)
        {
            Console.WriteLine(result);
        }
    }

    static int GetValueAtPosition(int[,] array, int x, int y)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        if (x < 1 || x > rows)
        {
            Console.WriteLine("Позиция по рядам выходит за пределы массива");
            return int.MinValue;
        }

        if (y < 1 || y > columns)
        {
            Console.WriteLine("Позиция по колонкам выходит за пределы массива");
            return int.MinValue;
        }

        return array[x - 1, y - 1];
    }
}
