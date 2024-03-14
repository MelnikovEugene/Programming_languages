// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// Пример: m = 2, n = 3 -> A(m,n) = 29

int m = 2;
int n = 3;

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

// В условии задачи, в примере (из презентации) - ошибка. При данном условии, когда A(m,n), а не A(n,m), A(m,n)=A(2,3)=9, а не 29
// 29 будет при A(3,2)

int result = Ackermann(m, n);
Console.WriteLine("Результат функции Аккермана для m = " + m + " и n = " + n + " равен " + result);
