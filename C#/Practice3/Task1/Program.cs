//Задайте массив. Напишите программу, которая определяет,
//присутствует ли заданное число в массиве. Программа
//должна выдать ответ: Да/Нет.
//Примеры
//[1 3 4 19 3], 8 => Нет
//[-4 3 4 1], 3 => Да

int[] array = { 1, 3, 4, 19, 3 };
int number = 15;
bool result = false;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == number)
    {
        result = true;
        break;
    }
}
if (result == true)
{
    System.Console.WriteLine("YES");
}
else
{
    System.Console.WriteLine("No");
}