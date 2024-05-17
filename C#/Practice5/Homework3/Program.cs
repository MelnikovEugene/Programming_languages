using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] numbers = new int[,] {
            {1, 2, 3},
            {1, 1, 0},
            {7, 8, 2},
            {9, 10, 11}
        };

        int minRowSum = int.MaxValue;
        int minRowIndex = -1;

        // Проходим по каждой строке и вычисляем сумму элементов
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            int rowSum = 0;
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                rowSum += numbers[i, j];
            }

            // Если текущая сумма меньше минимальной, обновляем минимальную сумму и индекс строки
            if (rowSum < minRowSum)
            {
                minRowSum = rowSum;
                minRowIndex = i;
            }
        }

        Console.WriteLine("Строка с наименьшей суммой элементов: " + minRowIndex);
    }
}

