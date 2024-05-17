// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Задаем исходную строку с буквами в разных регистрах
        string inputString = "Hello World Example";

        // Вызываем функцию для замены заглавных букв на строчные
        string resultString = ConvertToLowerCase(inputString);

        // Выводим результат на экран
        Console.WriteLine("Строка с замененными заглавными буквами: " + resultString);
    }

    // Функция для замены всех заглавных букв на строчные в строке
    static string ConvertToLowerCase(string input)
    {
        // Создаем пустую строку для результата
        string result = "";

        // Проходим по каждому символу в исходной строке
        foreach (char c in input)
        {
            // Проверяем, является ли текущий символ заглавной буквой
            if (Char.IsUpper(c))
            {
                // Если да, добавляем к результату строчную версию этой буквы
                result += Char.ToLower(c);
            }
            else
            {
                // Если нет, добавляем текущий символ без изменений
                result += c;
            }
        }

        // Возвращаем полученную строку
        return result;
    }
}
