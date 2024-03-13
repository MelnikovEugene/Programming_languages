int Fact(int n)
{
    if (n == 1 || n <= 0)
    {
        return 1;
    }
    System.Console.WriteLine(n);
    int a = n * Fact(n - 1);
    Console.WriteLine($"Возврат:n={n}, Fact={a}");
    return a;
}
System.Console.WriteLine(Fact(5));