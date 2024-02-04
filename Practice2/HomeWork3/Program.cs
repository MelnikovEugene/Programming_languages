//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
int number = 3;
if (number >= 10 && number <= 99)
{
    int maxDigit = 0;

    while (number > 0)
    {
        int digit = number % 10;
        maxDigit = Math.Max(maxDigit, digit);
        number /= 10;
    }

    Console.WriteLine($"Наибольшая цифра в числе - {maxDigit}.");
}
else
{
    Console.WriteLine("Некорректный ввод. Введите целое число от 10 до 99.");
}