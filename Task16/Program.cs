// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
double[] array = new double[5];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write($"Разница между максимальным и минимальным элетментами массива: {DiffArray(array)}");

void FillArray(double[] fillArray)
{
    int length = fillArray.Length;
    for (int index = 0; index < length; index++)
    {
        fillArray[index] = Math.Round((new Random().NextDouble()), 1) + new Random().Next(-10, 10);
    }
}

void PrintArray(double[] printArray)
{
    int length = printArray.Length;
    for (int index = 0; index < length; index++)
    {
        Console.Write($"{printArray[index]} ");
    }
}

double DiffArray(double[] diffArray)
{
    double min = diffArray[0];
    double max = diffArray[0];
    foreach (double el in diffArray)
    {
        if (min > el)
        {
            min = el;
        }
        if (max < el)
        {
            max = el;
        }
    }
    return max - min;
}
