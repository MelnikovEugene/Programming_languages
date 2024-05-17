// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int M = 5;
int N = 15;
void PrintNaturalNumbers(int current, int end)
{
    if (current > end)
    {
        return;
    }
    Console.Write($"{current} ");
    PrintNaturalNumbers(current + 1, end);
}
PrintNaturalNumbers(M, N);