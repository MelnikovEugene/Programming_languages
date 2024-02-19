// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.
using System;

class Program
{
    static void Main()
    {
        // Создаем массив из вещественных чисел
        double[] array = { 3.14, 2.71, 1.618, 4.669, 2.718, 3.141, 2.71828, 1.414, 2.718, 3.142 };

        // Находим разницу между максимальным и минимальным элементами массива
        double difference = FindDifference(array);

        // Выводим результат
        Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difference}");
    }

    // Метод для нахождения разницы между максимальным и минимальным элементами массива
    static double FindDifference(double[] array)
    {
        if (array.Length == 0)
        {
            throw new ArgumentException("Массив не может быть пустым.");
        }

        double min = array[0];
        double max = array[0];

        // Находим минимальный и максимальный элементы массива
        foreach (double element in array)
        {
            if (element < min)
            {
                min = element;
            }

            if (element > max)
            {
                max = element;
            }
        }

        // Вычисляем разницу между максимальным и минимальным элементами
        double difference = max - min;

        return difference;
    }
}
