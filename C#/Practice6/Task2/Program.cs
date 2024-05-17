// На основе символов строки (тип string) сформировать массив символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.

using System;

class Program
{
    static void Main()
    {
        string str = "Hello";
        char[] charArray = StringToCharArray(str);

        // Вывод массива на экран
        Console.WriteLine("Массив символов:");
        foreach (char c in charArray)
        {
            Console.Write(c + " ");
        }
        // Output: H e l l o
    }

    static char[] StringToCharArray(string str)
    {
        // Определяем размер массива как длину строки
        char[] charArray = new char[str.Length];
        
        // Заполняем массив символами из строки
        for (int i = 0; i < str.Length; i++)
        {
            charArray[i] = str[i];
        }
        
        return charArray;
    }
}

