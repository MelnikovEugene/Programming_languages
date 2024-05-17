// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9

int SumOfDigits(int num)
{
    if (num == 0)
    {
        return 0;
    }
    int sum = num % 10 + SumOfDigits(num / 10);
    return sum;
}
Console.Write(SumOfDigits(2354786));