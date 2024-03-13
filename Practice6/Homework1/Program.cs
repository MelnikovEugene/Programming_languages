//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Создаем двумерный массив символов
        char[,] charArray = {
            {'H', 'e', 'l', 'l', 'o'},
            {'W', 'o', 'r', 'l', 'd'}
        };

        // Вызываем функцию для создания строки из массива
        string resultString = ArrayToString(charArray);

        // Выводим результат на экран
        Console.WriteLine("Строка из символов массива: " + resultString);
    }

    // Функция для создания строки из двумерного массива символов
    static string ArrayToString(char[,] array)
    {
        // Инициализируем пустую строку
        string result = "";

        // Получаем размеры массива
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        // Проходим по каждому элементу массива
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Добавляем текущий символ к строке
                result += array[i, j];
            }
        }

        // Возвращаем полученную строку
        return result;
    }
}
