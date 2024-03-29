﻿// Считать строку с консоли, состоящую из латинских букв в нижнем регистре. Выяснить, сколько среди введённых букв гласных.

using System;

class Program
{
    static void Main()
    {
        // Предлагаем пользователю ввести строку с гласными буквами
        Console.WriteLine("Введите строку из латинских букв в нижнем регистре:");
        // Считываем введенную строку с консоли
        string input = Console.ReadLine();

        // Вызываем метод для подсчета количества гласных букв в строке
        int vowelCount = CountVowels(input);

        // Выводим результат на экран
        Console.WriteLine($"Количество гласных букв: {vowelCount}");
    }

    // Метод для подсчета количества гласных букв в строке
    static int CountVowels(string input)
    {
        int count = 0;
        // Перебираем каждый символ в строке
        foreach (char c in input)
        {
            // Проверяем, является ли текущий символ гласной буквой
            if (IsVowel(c))
            {
                // Если символ - гласная буква, увеличиваем счетчик на 1
                count++;
            }
        }
        return count; // Возвращаем общее количество гласных букв в строке
    }

    // Метод для проверки, является ли символ гласной буквой
    static bool IsVowel(char c)
    {
        // Проверяем, содержится ли текущий символ в строке "aeiou", которая содержит гласные буквы
        return "aeiou".Contains(c);
    }
}

