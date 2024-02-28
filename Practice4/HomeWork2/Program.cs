﻿// Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Создаем объект Random для генерации случайных чисел
        Random random = new Random();

        // Задаем размер массива
        int[] array = new int[10000]; // Например, создадим массив из 100 элементов

        // Заполняем массив случайными трехзначными числами и выводим его на экран
        Console.WriteLine("Созданный массив:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100, 1000); // Генерируем случайное число от 100 до 999 (трехзначное число)
            Console.Write(array[i] + " "); // Выводим текущий элемент массива на экран
        }

        // Переменная для подсчета количества четных чисел
        int evenCount = 0;

        // Перебираем все элементы массива
        foreach (int num in array)
        {
            // Проверяем, является ли текущее число четным
            if (num % 2 == 0)
            {
                evenCount++; // Увеличиваем счетчик четных чисел
            }
        }

        // Выводим результат
        Console.WriteLine($"\nКоличество чётных чисел в массиве: {evenCount}");
    }
}
