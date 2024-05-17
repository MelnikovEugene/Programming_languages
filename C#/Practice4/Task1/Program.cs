//Задайте одномерный массив, заполненный случайными числами. Определите количество простых чисел в этом массиве.
//Примеры
//[1 3 4 19 3] => 2
//[4 3 4 1 9 5 21 13] => 3

// Задаем размер массива и создаем его
int arraySize = 500; // Можем изменить размер по своему усмотрению
int[] randomArray = new int[arraySize];

// Заполняем массив случайными числами
Random random = new Random();
for (int i = 0; i < arraySize; i++)
{
    randomArray[i] = random.Next(100, 1000); // Диапазон чисел также можно изменить
}

// Выводим массив на экран
Console.WriteLine("Случайный массив:");
foreach (var number in randomArray)
{
    Console.Write(number + " ");
}
Console.WriteLine();

// Определяем количество простых чисел в массиве
int primeCount = CountPrimes(randomArray);

// Выводим результат
Console.WriteLine($"Количество простых чисел в массиве: {primeCount}");

Console.WriteLine();

// Метод для определения является ли число простым
static bool IsPrime(int number)
{
    if (number < 2)
        return false;

    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
            return false;
    }

    return true;
}

// Метод для подсчета простых чисел в массиве
static int CountPrimes(int[] array)
{
    int count = 0;

    foreach (var number in array)
    {
        if (IsPrime(number))
            count++;
    }

    return count;
}