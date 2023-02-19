// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

Console.Write("Введите количество строк  массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцы  массива: ");
int columns = int.Parse(Console.ReadLine()!);


double[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
AverageArray(array);

double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble() * 10);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
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

void AverageArray(double[,] aveArray)
{
    for (int i = 0; i < aveArray.GetLength(0) - 2; i++)
    {
        int average = 0;
        for (int j = 0; j < aveArray.GetLength(1); j++)
        {
            Console.Write($"{(aveArray[i, j] + aveArray[i + 1, j] + aveArray[i + 2, j]) / aveArray.GetLength(0)} ");
        }
    }
}
