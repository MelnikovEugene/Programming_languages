﻿Console.Write("Введите целое число: ");

        // Считываем введенную строку с консоли
        string input = Console.ReadLine();

        // Пытаемся преобразовать введенную строку в целое число
        if (int.TryParse(input, out int N))
        {
            // Если преобразование успешно, выводим число
            Console.WriteLine("Вы ввели число: " + N);
        }
        else
        {
            // Если введенная строка не является целым числом, выводим сообщение об ошибке
            Console.WriteLine("Некорректный ввод. Введите целое число.");
        }
for (int i = -N; i <= N; i++)
    {
        // Выводим текущее число
        Console.Write(i);

        // Добавляем запятую и пробел, если число не последнее в диапазоне
        if (i < N)
        {
            Console.Write(", ");
        }
    }

