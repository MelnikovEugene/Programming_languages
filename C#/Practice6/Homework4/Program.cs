// Задача 4: Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Задаем исходную строку
        string inputString = "Hello World Example";

        // Вызываем функцию для разворота слов в строке
        string reversedString = ReverseWords(inputString);

        // Выводим результат на экран
        Console.WriteLine("Результат: " + reversedString);
    }

    // Функция для разворота слов в строке
    static string ReverseWords(string str)
    {
        // Разделяем исходную строку на слова
        string[] words = str.Split(' ');

        // Создаем пустую строку для результата
        string result = "";

        // Проходим по словам в обратном порядке
        for (int i = words.Length - 1; i >= 0; i--)
        {
            // Добавляем текущее слово к результату
            result += words[i];

            // Добавляем пробел после слова, если это не последнее слово
            if (i > 0)
            {
                result += " ";
            }
        }

        // Возвращаем полученную строку с развернутыми словами
        return result;
    }
}
