//Задайте массив из 10 элементов, заполненный числами из
//промежутка [-10, 10]. Замените отрицательные элементы на
//положительные, а положительные на отрицательные.
//Пример
//[1 -5 6]
//=> [-1 5 -6]

int[] array = new int[10] { 2, 5, 7, 4, -5, 7, -2, -9, 3, 10 };
Console.WriteLine("Исходный массив:");
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + " ");
    array[i] = array[i] * -1;
}
System.Console.WriteLine();
Console.WriteLine("Получившийся массив:");
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + " ");
}
