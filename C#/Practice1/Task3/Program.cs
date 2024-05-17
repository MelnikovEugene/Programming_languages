Console.Write("Введите трёхзначное целое число: ");

// Пытаемся преобразовать введенную строку в целое число
if (int.TryParse(Console.ReadLine(), out int number))
{
    // Проверяем, что число трёхзначное
    if (number >= 100 && number <= 999)
    {
        // Вычисляем сумму первой и последней цифры
        int sum = CalculateSumOfFirstAndLastDigit(number);

        // Выводим результат
        Console.WriteLine($"Сумма первой и последней цифры: {sum}");
    }
    else
    {
        Console.WriteLine("Ошибка ввода. Пожалуйста, введите трёхзначное число.");
    }
}
else
{
    Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное целое число.");
}


static int CalculateSumOfFirstAndLastDigit(int num)
{
    // Получаем последнюю цифру
    int lastDigit = num % 10;

    // Получаем первую цифру
    int firstDigit = num / 100;

    // Вычисляем сумму
    int sum = firstDigit + lastDigit;

    return sum;
}
