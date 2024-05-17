//Задайте массив из N случайных целых чисел (N вводится с клавиатуры). Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.
//Пример [1 5 11 21 81 4 0 91 2 3] => 2

// Генерирует массив случайных целых чисел заданного размера.
static int[] GenerateRandomNumbers(int N, int MinValue, int MaxValue)
{
    Random random = new Random();
    int[] numbers = new int[N];
    for (int i = 0; i < N; i++)
    {
        numbers[i] = random.Next(MinValue, MaxValue);
    }
    return numbers;
}

// Выводит массив целых чисел на экран.
static void PrintArray(int[] array)
{
    foreach (var number in array)
    {
        Console.Write(number + " ");
    }
    Console.WriteLine();
}

// Подсчитывает количество чисел в массиве, оканчивающихся на 1 и делящихся нацело на 7.
static int CountNumbersEndingWithOneAndDivisibleBySeven(int[] array)
{
    int count = 0;
    foreach (var number in array)
    {
        if (number % 10 == 1 && number % 7 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите размер массива N: ");
if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
{
    // Создаем массив из N случайных целых чисел
    int[] numbers = GenerateRandomNumbers(N, 100, 1000);

    // Выводим массив на экран
    Console.WriteLine("Сгенерированный массив:");
    PrintArray(numbers);

    // Находим количество чисел, оканчивающихся на 1 и делящихся нацело на 7
    int count = CountNumbersEndingWithOneAndDivisibleBySeven(numbers);

    // Выводим результат
    Console.WriteLine($"Количество чисел, оканчивающихся на 1 и делящихся нацело на 7: {count}");
}
else
{
    Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное целое число.");
}



