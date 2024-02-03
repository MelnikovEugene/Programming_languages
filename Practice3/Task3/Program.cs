//Найдите произведения пар чисел в одномерном массиве. Парой
//считаем первый и последний элемент, второй и предпоследний и
//т.д. Результат запишите в новый массив.
//Пример
//[1 3 2 4 2 3] => [3 6 8]
//[2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

int[] array = { 1, 3, 2, 4, 2, 3 };
int length = array.Length;
int pairsCount = length / 2;
int[] result = new int[pairsCount];
for (int i = 0; i < pairsCount; i++)
{
    result[i] = array[i] * array[length - 1 - i];
}
Console.WriteLine("Исходный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine("Результат: [" + string.Join(", ", result) + "]\n");
