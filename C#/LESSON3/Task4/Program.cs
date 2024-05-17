Random rnd = new Random();
int size = 500;
int[] arr_int = new int[size];
int i = 0;
while (i < size)
{
    arr_int[i] = rnd.Next(1, 10);
    i = i + 1;
}
i = 0;
while (i < size)
{
    Console.Write($"{arr_int[i]} ");
    i = i + 1;
}

size = 10;
int[] arr_int2 = new int[size];
i = 0;
while (i < size)
{
    System.Console.WriteLine($"Введите элемент массива с индексом {i}:");
    string input = Console.ReadLine();
    arr_int2[i] = Convert.ToInt32(input);
    i = i + 1;
}
i = 0;
while (i < size)
{
    Console.Write($"{arr_int2[i]} ");
    i = i + 1;
}