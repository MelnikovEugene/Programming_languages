/* Задайте массив символов (тип char []). Создайте строку из символов этого массива.
Указание
Конструктор строки вида string(char []) не использовать. */

using System;

class Program
{
    static void Main()
    {
        char[] charArray = { 'H', 'e', 'l', 'l', 'o' };
        string str = CharArrayToString(charArray);
        Console.WriteLine(str); // Output: Hello
    }

    static string CharArrayToString(char[] charArray)
    {
        // Создаем пустую строку
        string result = "";
        
        // Перебираем каждый символ в массиве и добавляем его к строке
        foreach (char c in charArray)
        {
            result += c;
        }
        
        return result;
    }
}
