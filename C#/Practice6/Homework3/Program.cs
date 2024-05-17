// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Задаем произвольную строку
        string inputString = "radar";

        // Проверяем, является ли строка палиндромом
        bool isPalindrome = IsPalindrome(inputString);

        // Выводим результат на экран
        if (isPalindrome)
        {
            Console.WriteLine("Строка \"" + inputString + "\" является палиндромом.");
        }
        else
        {
            Console.WriteLine("Строка \"" + inputString + "\" не является палиндромом.");
        }
    }

    // Функция для проверки, является ли строка палиндромом
    static bool IsPalindrome(string str)
    {
        // Преобразуем строку в массив символов
        char[] charArray = str.ToCharArray();

        // Устанавливаем индексы начала и конца строки
        int startIndex = 0;
        int endIndex = charArray.Length - 1;

        // Пока индекс начала строки меньше индекса конца строки
        while (startIndex < endIndex)
        {
            // Если символы на текущих позициях не совпадают, строка не является палиндромом
            if (charArray[startIndex] != charArray[endIndex])
            {
                return false;
            }

            // Сдвигаем индексы начала и конца строки
            startIndex++;
            endIndex--;
        }

        // Если мы дошли до этой точки, строка является палиндромом
        return true;
    }
}
