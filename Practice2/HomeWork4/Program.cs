//Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.Write($"Цифры числа через запятую: ");
int n = 597423;
int divisor = 1;
bool isFirstDigit = true;

while (n / divisor >= 10)
{
    divisor *= 10;
}
while (divisor > 0)
{
    int digit = n / divisor;
    n %= divisor;
    divisor /= 10;

    if (!isFirstDigit)
    {
        Console.Write(", ");
    }

    Console.Write(digit);
    isFirstDigit = false;
}

Console.WriteLine();

