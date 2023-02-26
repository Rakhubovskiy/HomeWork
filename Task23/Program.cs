// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке,
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Console.Write("Введите количество строк  массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцы  массива: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение элемента: ");
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элемента: ");
int maxValue = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
Console.WriteLine();
Console.Write($"Наименьшая сумма элементов в {GetRow(array)} строке");

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int GetRow(int[,] inArray)
{
    int row = 0;
    int minSum = 0;
    for (int k = 0; k < inArray.GetLength(1); k++)
    {
        minSum += inArray[0, k];
    }
    for (int i = 1; i < inArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i, j];
        }
        if (minSum > sum)
        {
            minSum = sum;
            row = i;
        }
    }
    return row + 1;
}
