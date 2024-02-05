//Заполните массив на N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9.
//Сформируйте целое число, которое будет состоять из цифр из массива. Старший разряд числа находится на 0-м индексе, младший – на последнем.

Console.Write("Введите размер массива N (не более 8): ");
if (int.TryParse(Console.ReadLine(), out int N) && N > 0 && N <= 8)
{
    // Создаем массив на N случайных целых чисел от 0 до 9
    int[] randomNumbers = GenerateRandomNumbers(N);

    // Выводим массив на экран
    Console.WriteLine("Сгенерированный массив:");
    PrintArray(randomNumbers);

    // Формируем целое число из цифр массива
    int formedNumber = FormNumberFromDigits(randomNumbers);

    // Выводим результат
    Console.WriteLine($"Сформированное целое число: {formedNumber}");
}
else
{
    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 1 до 8.");
}

static int[] GenerateRandomNumbers(int N)
{
    Random random = new Random();
    int[] numbers = new int[N];
    for (int i = 0; i < N; i++)
    {
        numbers[i] = random.Next(0, 10); // Генерируем случайное число от 0 до 9
    }
    return numbers;
}

static void PrintArray(int[] array)
{
    foreach (var number in array)
    {
        Console.Write(number + " ");
    }
    Console.WriteLine();
}

static int FormNumberFromDigits(int[] array)
{
    int formedNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        formedNumber = formedNumber * 10 + array[i];
    }
    return formedNumber;
}
