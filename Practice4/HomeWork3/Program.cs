// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

using System;

class Program
{
    static void Main(string[] args)
    {
        // Исходный массив
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Переворачиваем массив
        ReverseArray(array);

        // Выводим перевернутый массив
        Console.WriteLine("Перевернутый массив:");
        PrintArray(array);
    }

    // Метод для переворачивания массива
    static void ReverseArray(int[] arr)
    {
        int left = 0; // Индекс первого элемента
        int right = arr.Length - 1; // Индекс последнего элемента

        // Пока не встретятся индексы пересекаются
        while (left < right)
        {
            // Обмен значениями между первым и последним элементами
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;

            // Переходим к следующему элементу слева
            left++;

            // Переходим к следующему элементу справа
            right--;
        }
    }

    // Метод для вывода массива на экран
    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
