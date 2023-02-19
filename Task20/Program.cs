// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> по такому индексу нет элемента

Console.Clear();

Console.Write("Введите количество строк  массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцы  массива: ");
int columns = int.Parse(Console.ReadLine()!);

Console.Write("Введите строку для поиска элемента: ");
int rowsFind = int.Parse(Console.ReadLine()!);
Console.Write("Введите столбец для поиска элемента: ");
int columnsFind = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(rows, columns);
PrintArray(array);
if (FindElement(array) == 0)
{
    Console.Write("По такому индексу нет элемента");
}
else
{
    Console.Write($"На заданом индексе находится элемент: {FindElement(array)}");
}

double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round((new Random().NextDouble()), 1) + new Random().Next(-10, 10);
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

double FindElement(double[,] inArray)
{
    double el = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if ((i == rowsFind) && (j == columnsFind))
            {
                el = inArray[i, j];
            }
        }
    }
    return el;
}